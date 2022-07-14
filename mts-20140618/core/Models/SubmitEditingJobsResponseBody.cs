// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitEditingJobsResponseBody : TeaModel {
        [NameInMap("JobResultList")]
        [Validation(Required=false)]
        public SubmitEditingJobsResponseBodyJobResultList JobResultList { get; set; }
        public class SubmitEditingJobsResponseBodyJobResultList : TeaModel {
            [NameInMap("JobResult")]
            [Validation(Required=false)]
            public List<SubmitEditingJobsResponseBodyJobResultListJobResult> JobResult { get; set; }
            public class SubmitEditingJobsResponseBodyJobResultListJobResult : TeaModel {
                public string Code { get; set; }
                public SubmitEditingJobsResponseBodyJobResultListJobResultJob Job { get; set; }
                public class SubmitEditingJobsResponseBodyJobResultListJobResultJob : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }

                    [NameInMap("EditingConfig")]
                    [Validation(Required=false)]
                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfig EditingConfig { get; set; }
                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfig : TeaModel {
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigAudio Audio { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigAudio : TeaModel {
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
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigAudioVolume Volume { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigAudioVolume : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigClip Clip { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigClip : TeaModel {
                            [NameInMap("TimeSpan")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigClipTimeSpan TimeSpan { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigClipTimeSpan : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigContainer Container { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigContainer : TeaModel {
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }
                        [NameInMap("DeWatermark")]
                        [Validation(Required=false)]
                        public string DeWatermark { get; set; }
                        [NameInMap("DigiWaterMark")]
                        [Validation(Required=false)]
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigDigiWaterMark DigiWaterMark { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigDigiWaterMark : TeaModel {
                            [NameInMap("Alpha")]
                            [Validation(Required=false)]
                            public string Alpha { get; set; }

                            [NameInMap("InputFile")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigDigiWaterMarkInputFile InputFile { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigDigiWaterMarkInputFile : TeaModel {
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
                        [NameInMap("Editing")]
                        [Validation(Required=false)]
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditing Editing { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditing : TeaModel {
                            [NameInMap("ClipList")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipList ClipList { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipList : TeaModel {
                                [NameInMap("Clip")]
                                [Validation(Required=false)]
                                public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipListClip> Clip { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipListClip : TeaModel {
                                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipListClipEffects Effects { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipListClipEffects : TeaModel {
                                        [NameInMap("Effect")]
                                        [Validation(Required=false)]
                                        public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipListClipEffectsEffect> Effect { get; set; }
                                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingClipListClipEffectsEffect : TeaModel {
                                            [NameInMap("Effect")]
                                            [Validation(Required=false)]
                                            public string Effect { get; set; }

                                            [NameInMap("EffectConfig")]
                                            [Validation(Required=false)]
                                            public string EffectConfig { get; set; }

                                        }

                                    }
                                    public string Id { get; set; }
                                    public string In { get; set; }
                                    public string Out { get; set; }
                                    public string SourceID { get; set; }
                                    public string SourceStrmMap { get; set; }
                                    public string SourceType { get; set; }
                                    public string Type { get; set; }
                                }
                            };

                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimeline Timeline { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimeline : TeaModel {
                                [NameInMap("TimelineConfig")]
                                [Validation(Required=false)]
                                public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTimelineConfig TimelineConfig { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTimelineConfig : TeaModel {
                                    [NameInMap("TimelineConfigAudio")]
                                    [Validation(Required=false)]
                                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTimelineConfigTimelineConfigAudio TimelineConfigAudio { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTimelineConfigTimelineConfigAudio : TeaModel {
                                        [NameInMap("ChannelLayout")]
                                        [Validation(Required=false)]
                                        public string ChannelLayout { get; set; }
                                        [NameInMap("Channels")]
                                        [Validation(Required=false)]
                                        public string Channels { get; set; }
                                        [NameInMap("Samplerate")]
                                        [Validation(Required=false)]
                                        public string Samplerate { get; set; }
                                    };

                                    [NameInMap("TimelineConfigVideo")]
                                    [Validation(Required=false)]
                                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTimelineConfigTimelineConfigVideo TimelineConfigVideo { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTimelineConfigTimelineConfigVideo : TeaModel {
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
                                    };

                                }
                                [NameInMap("TrackList")]
                                [Validation(Required=false)]
                                public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackList TrackList { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackList : TeaModel {
                                    [NameInMap("Track")]
                                    [Validation(Required=false)]
                                    public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrack> Track { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrack : TeaModel {
                                        [NameInMap("Clips")]
                                        [Validation(Required=false)]
                                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClips Clips { get; set; }
                                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClips : TeaModel {
                                            [NameInMap("Clip")]
                                            [Validation(Required=false)]
                                            public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClipsClip> Clip { get; set; }
                                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClipsClip : TeaModel {
                                                public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfig ClipsConfig { get; set; }
                                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfig : TeaModel {
                                                    [NameInMap("ClipsConfigVideo")]
                                                    [Validation(Required=false)]
                                                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo ClipsConfigVideo { get; set; }
                                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEditingTimelineTrackListTrackClipsClipClipsConfigClipsConfigVideo : TeaModel {
                                                        [NameInMap("L")]
                                                        [Validation(Required=false)]
                                                        public string L { get; set; }
                                                        [NameInMap("T")]
                                                        [Validation(Required=false)]
                                                        public string T { get; set; }
                                                    };

                                                }
                                                public string In { get; set; }
                                                public string Out { get; set; }
                                                public string ClipID { get; set; }
                                            }
                                        };

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
                            };

                        }
                        [NameInMap("Encryption")]
                        [Validation(Required=false)]
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEncryption Encryption { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigEncryption : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigM3U8NonStandardSupport M3U8NonStandardSupport { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigM3U8NonStandardSupport : TeaModel {
                            [NameInMap("TS")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigM3U8NonStandardSupportTS TS { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigM3U8NonStandardSupportTS : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMergeList MergeList { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMergeList : TeaModel {
                            [NameInMap("Merge")]
                            [Validation(Required=false)]
                            public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMergeListMerge> Merge { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMergeListMerge : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMuxConfig MuxConfig { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMuxConfig : TeaModel {
                            [NameInMap("Gif")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMuxConfigGif Gif { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMuxConfigGif : TeaModel {
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
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMuxConfigSegment Segment { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigMuxConfigSegment : TeaModel {
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }
                            };

                        }
                        [NameInMap("OutputFile")]
                        [Validation(Required=false)]
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigOutputFile OutputFile { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigOutputFile : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigProperties Properties { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigProperties : TeaModel {
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
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesFormat Format { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesFormat : TeaModel {
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
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreams Streams { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreams : TeaModel {
                                [NameInMap("AudioStreamList")]
                                [Validation(Required=false)]
                                public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsAudioStreamList : TeaModel {
                                    [NameInMap("AudioStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                                public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsSubtitleStreamList : TeaModel {
                                    [NameInMap("SubtitleStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                                public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsVideoStreamList : TeaModel {
                                    [NameInMap("VideoStream")]
                                    [Validation(Required=false)]
                                    public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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
                                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfig SubtitleConfig { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfig : TeaModel {
                            [NameInMap("ExtSubtitleList")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigExtSubtitleList ExtSubtitleList { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigExtSubtitleList : TeaModel {
                                [NameInMap("ExtSubtitle")]
                                [Validation(Required=false)]
                                public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitle> ExtSubtitle { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitle : TeaModel {
                                    public string CharEnc { get; set; }
                                    public string FontName { get; set; }
                                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitleInput Input { get; set; }
                                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigExtSubtitleListExtSubtitleInput : TeaModel {
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
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigSubtitleList SubtitleList { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigSubtitleList : TeaModel {
                                [NameInMap("Subtitle")]
                                [Validation(Required=false)]
                                public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigSubtitleListSubtitle> Subtitle { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSubtitleConfigSubtitleListSubtitle : TeaModel {
                                    public string Map { get; set; }
                                }
                            };

                        }
                        [NameInMap("SuperReso")]
                        [Validation(Required=false)]
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSuperReso SuperReso { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigSuperReso : TeaModel {
                            [NameInMap("IsHalfSample")]
                            [Validation(Required=false)]
                            public string IsHalfSample { get; set; }

                        }
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }
                        [NameInMap("TransConfig")]
                        [Validation(Required=false)]
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigTransConfig TransConfig { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigTransConfig : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigVideo Video { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigVideo : TeaModel {
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("BitrateBnd")]
                            [Validation(Required=false)]
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigVideoBitrateBnd BitrateBnd { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigVideoBitrateBnd : TeaModel {
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
                        public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigWaterMarkList WaterMarkList { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigWaterMarkList : TeaModel {
                            [NameInMap("WaterMark")]
                            [Validation(Required=false)]
                            public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigWaterMarkListWaterMark> WaterMark { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigWaterMarkListWaterMark : TeaModel {
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
                                public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigWaterMarkListWaterMarkInputFile InputFile { get; set; }
                                public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingConfigWaterMarkListWaterMarkInputFile : TeaModel {
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

                    [NameInMap("EditingInputs")]
                    [Validation(Required=false)]
                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputs EditingInputs { get; set; }
                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputs : TeaModel {
                        [NameInMap("EditingInput")]
                        [Validation(Required=false)]
                        public List<SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputsEditingInput> EditingInput { get; set; }
                        public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputsEditingInput : TeaModel {
                            public string Id { get; set; }
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputsEditingInputInputConfig InputConfig { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputsEditingInputInputConfig : TeaModel {
                                [NameInMap("DeinterlaceMethod")]
                                [Validation(Required=false)]
                                public string DeinterlaceMethod { get; set; }

                                [NameInMap("IsNormalSar")]
                                [Validation(Required=false)]
                                public string IsNormalSar { get; set; }

                            }
                            public SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputsEditingInputInputFile InputFile { get; set; }
                            public class SubmitEditingJobsResponseBodyJobResultListJobResultJobEditingInputsEditingInputInputFile : TeaModel {
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

                    [NameInMap("FinishTime")]
                    [Validation(Required=false)]
                    public string FinishTime { get; set; }

                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("MNSMessageResult")]
                    [Validation(Required=false)]
                    public SubmitEditingJobsResponseBodyJobResultListJobResultJobMNSMessageResult MNSMessageResult { get; set; }
                    public class SubmitEditingJobsResponseBodyJobResultListJobResultJobMNSMessageResult : TeaModel {
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
