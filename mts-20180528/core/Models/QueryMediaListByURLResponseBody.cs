// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class QueryMediaListByURLResponseBody : TeaModel {
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public QueryMediaListByURLResponseBodyMediaList MediaList { get; set; }
        public class QueryMediaListByURLResponseBodyMediaList : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public List<QueryMediaListByURLResponseBodyMediaListMedia> Media { get; set; }
            public class QueryMediaListByURLResponseBodyMediaListMedia : TeaModel {
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                [NameInMap("CensorState")]
                [Validation(Required=false)]
                public string CensorState { get; set; }

                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("File")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaFile File { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaFile : TeaModel {
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("MediaInfo")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaMediaInfo MediaInfo { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfo : TeaModel {
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoFormat Format { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoFormat : TeaModel {
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

                    [NameInMap("Streams")]
                    [Validation(Required=false)]
                    public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreams Streams { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreams : TeaModel {
                        [NameInMap("AudioStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList AudioStreamList { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList : TeaModel {
                            [NameInMap("AudioStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                            public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream : TeaModel {
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
                        public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList : TeaModel {
                            [NameInMap("SubtitleStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                            public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                        public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList VideoStreamList { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList : TeaModel {
                            [NameInMap("VideoStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                            public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream : TeaModel {
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
                                public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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

                    }

                }

                [NameInMap("PlayList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaPlayList PlayList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaPlayList : TeaModel {
                    [NameInMap("Play")]
                    [Validation(Required=false)]
                    public List<QueryMediaListByURLResponseBodyMediaListMediaPlayListPlay> Play { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaPlayListPlay : TeaModel {
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
                        public QueryMediaListByURLResponseBodyMediaListMediaPlayListPlayFile File { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaPlayListPlayFile : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

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

                [NameInMap("PublishState")]
                [Validation(Required=false)]
                public string PublishState { get; set; }

                [NameInMap("RunIdList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaRunIdList RunIdList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaRunIdList : TeaModel {
                    [NameInMap("RunId")]
                    [Validation(Required=false)]
                    public List<string> RunId { get; set; }

                }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                [NameInMap("SnapshotList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaSnapshotList SnapshotList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaSnapshotList : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshot> Snapshot { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshot : TeaModel {
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshotFile File { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshotFile : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

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

                [NameInMap("SummaryList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaSummaryList SummaryList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaSummaryList : TeaModel {
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummary> Summary { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummary : TeaModel {
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummaryFile File { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummaryFile : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

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

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaTags Tags { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<string> Tag { get; set; }

                }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        [NameInMap("NonExistFileURLs")]
        [Validation(Required=false)]
        public QueryMediaListByURLResponseBodyNonExistFileURLs NonExistFileURLs { get; set; }
        public class QueryMediaListByURLResponseBodyNonExistFileURLs : TeaModel {
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public List<string> FileURL { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
