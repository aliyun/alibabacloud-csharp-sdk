// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaListResponseBody : TeaModel {
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public QueryMediaListResponseBodyMediaList MediaList { get; set; }
        public class QueryMediaListResponseBodyMediaList : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public List<QueryMediaListResponseBodyMediaListMedia> Media { get; set; }
            public class QueryMediaListResponseBodyMediaListMedia : TeaModel {
                public string Bitrate { get; set; }
                public long? CateId { get; set; }
                public string CensorState { get; set; }
                public string CoverURL { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string Duration { get; set; }
                public QueryMediaListResponseBodyMediaListMediaFile File { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaFile : TeaModel {
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }
                public string Format { get; set; }
                public string Fps { get; set; }
                public string Height { get; set; }
                public string MediaId { get; set; }
                public QueryMediaListResponseBodyMediaListMediaMediaInfo MediaInfo { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaMediaInfo : TeaModel {
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public QueryMediaListResponseBodyMediaListMediaMediaInfoFormat Format { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaMediaInfoFormat : TeaModel {
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

                    [NameInMap("Streams")]
                    [Validation(Required=false)]
                    public QueryMediaListResponseBodyMediaListMediaMediaInfoStreams Streams { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreams : TeaModel {
                        [NameInMap("AudioStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList AudioStreamList { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList : TeaModel {
                            [NameInMap("AudioStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                            public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream : TeaModel {
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
                        public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList : TeaModel {
                            [NameInMap("SubtitleStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                            public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                        public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList VideoStreamList { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList : TeaModel {
                            [NameInMap("VideoStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                            public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream : TeaModel {
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
                                public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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

                                [NameInMap("Rotate")]
                                [Validation(Required=false)]
                                public string Rotate { get; set; }

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

                }
                public QueryMediaListResponseBodyMediaListMediaPlayList PlayList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaPlayList : TeaModel {
                    [NameInMap("Play")]
                    [Validation(Required=false)]
                    public List<QueryMediaListResponseBodyMediaListMediaPlayListPlay> Play { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaPlayListPlay : TeaModel {
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        [NameInMap("Encryption")]
                        [Validation(Required=false)]
                        public string Encryption { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaPlayListPlayFile File { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaPlayListPlayFile : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }
                        };

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }
                public string PublishState { get; set; }
                public QueryMediaListResponseBodyMediaListMediaRunIdList RunIdList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaRunIdList : TeaModel {
                    [NameInMap("RunId")]
                    [Validation(Required=false)]
                    public List<string> RunId { get; set; }

                }
                public string Size { get; set; }
                public QueryMediaListResponseBodyMediaListMediaSnapshotList SnapshotList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaSnapshotList : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshot> Snapshot { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshot : TeaModel {
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshotFile File { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshotFile : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }
                        };

                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }
                public QueryMediaListResponseBodyMediaListMediaSummaryList SummaryList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaSummaryList : TeaModel {
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<QueryMediaListResponseBodyMediaListMediaSummaryListSummary> Summary { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaSummaryListSummary : TeaModel {
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaSummaryListSummaryFile File { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaSummaryListSummaryFile : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }
                        };

                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }
                public QueryMediaListResponseBodyMediaListMediaTags Tags { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<string> Tag { get; set; }

                }
                public string Title { get; set; }
                public string Width { get; set; }
            }
        };

        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public QueryMediaListResponseBodyNonExistMediaIds NonExistMediaIds { get; set; }
        public class QueryMediaListResponseBodyNonExistMediaIds : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
