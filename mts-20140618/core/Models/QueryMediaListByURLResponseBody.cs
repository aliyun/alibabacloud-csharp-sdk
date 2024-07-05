// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaListByURLResponseBody : TeaModel {
        /// <summary>
        /// The list of media files.
        /// </summary>
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public QueryMediaListByURLResponseBodyMediaList MediaList { get; set; }
        public class QueryMediaListByURLResponseBodyMediaList : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public List<QueryMediaListByURLResponseBodyMediaListMedia> Media { get; set; }
            public class QueryMediaListByURLResponseBodyMediaListMedia : TeaModel {
                /// <summary>
                /// The bitrate.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The ID of the category to which the media file belongs.
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// The review status of the media file. Valid values:
                /// 
                /// *   **Initiated**: The media file is uploaded but not reviewed.
                /// *   **Pass**: The media file is uploaded and passes the review.
                /// </summary>
                [NameInMap("CensorState")]
                [Validation(Required=false)]
                public string CensorState { get; set; }

                /// <summary>
                /// The OSS URL of the thumbnail.
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// The time when the media file was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The duration.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The details of the input file.
                /// </summary>
                [NameInMap("File")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaFile File { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaFile : TeaModel {
                    /// <summary>
                    /// The status of the media file. Valid values:
                    /// 
                    /// *   **Normal**: The file is normal.
                    /// *   **Deleted**: The file is deleted.
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// The OSS URL of the input file.
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

                /// <summary>
                /// The encoding format. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// The frame rate.
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// The height of the queried media file.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// The ID of the media file.
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// The media information.
                /// </summary>
                [NameInMap("MediaInfo")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaMediaInfo MediaInfo { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfo : TeaModel {
                    /// <summary>
                    /// The format information.
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoFormat Format { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoFormat : TeaModel {
                        /// <summary>
                        /// The bitrate.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The duration.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// The full name of the encoding format.
                        /// </summary>
                        [NameInMap("FormatLongName")]
                        [Validation(Required=false)]
                        public string FormatLongName { get; set; }

                        /// <summary>
                        /// The short name of the container format. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.
                        /// </summary>
                        [NameInMap("FormatName")]
                        [Validation(Required=false)]
                        public string FormatName { get; set; }

                        /// <summary>
                        /// The total number of program streams.
                        /// </summary>
                        [NameInMap("NumPrograms")]
                        [Validation(Required=false)]
                        public string NumPrograms { get; set; }

                        /// <summary>
                        /// The total number of media streams.
                        /// </summary>
                        [NameInMap("NumStreams")]
                        [Validation(Required=false)]
                        public string NumStreams { get; set; }

                        /// <summary>
                        /// The size.
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        /// <summary>
                        /// The start time.
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// The stream information.
                    /// </summary>
                    [NameInMap("Streams")]
                    [Validation(Required=false)]
                    public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreams Streams { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreams : TeaModel {
                        /// <summary>
                        /// The list of audio streams.
                        /// </summary>
                        [NameInMap("AudioStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList AudioStreamList { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList : TeaModel {
                            [NameInMap("AudioStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                            public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream : TeaModel {
                                /// <summary>
                                /// The bitrate.
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// The output layout of the sound channels.
                                /// </summary>
                                [NameInMap("ChannelLayout")]
                                [Validation(Required=false)]
                                public string ChannelLayout { get; set; }

                                /// <summary>
                                /// The number of sound channels.
                                /// </summary>
                                [NameInMap("Channels")]
                                [Validation(Required=false)]
                                public string Channels { get; set; }

                                /// <summary>
                                /// The full name of the encoding format.
                                /// </summary>
                                [NameInMap("CodecLongName")]
                                [Validation(Required=false)]
                                public string CodecLongName { get; set; }

                                /// <summary>
                                /// The short name of the encoding format. Valid values: H264, mov, aac, avc, and mpeg.
                                /// </summary>
                                [NameInMap("CodecName")]
                                [Validation(Required=false)]
                                public string CodecName { get; set; }

                                /// <summary>
                                /// The tag of the encoding format.
                                /// </summary>
                                [NameInMap("CodecTag")]
                                [Validation(Required=false)]
                                public string CodecTag { get; set; }

                                /// <summary>
                                /// The tag string of the encoding format.
                                /// </summary>
                                [NameInMap("CodecTagString")]
                                [Validation(Required=false)]
                                public string CodecTagString { get; set; }

                                /// <summary>
                                /// The codec time base.
                                /// </summary>
                                [NameInMap("CodecTimeBase")]
                                [Validation(Required=false)]
                                public string CodecTimeBase { get; set; }

                                /// <summary>
                                /// The duration of the media file.
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// The sequence number of the audio stream. The value indicates the position of the audio stream in all audio streams.
                                /// </summary>
                                [NameInMap("Index")]
                                [Validation(Required=false)]
                                public string Index { get; set; }

                                /// <summary>
                                /// The language. For more information, see [FFmpeg language definition](https://www.ffmpeg.org/ffmpeg-all.html#Metadata).
                                /// </summary>
                                [NameInMap("Lang")]
                                [Validation(Required=false)]
                                public string Lang { get; set; }

                                /// <summary>
                                /// The total number of frames.
                                /// </summary>
                                [NameInMap("NumFrames")]
                                [Validation(Required=false)]
                                public string NumFrames { get; set; }

                                /// <summary>
                                /// The sampling format.
                                /// </summary>
                                [NameInMap("SampleFmt")]
                                [Validation(Required=false)]
                                public string SampleFmt { get; set; }

                                /// <summary>
                                /// The sampling rate.
                                /// </summary>
                                [NameInMap("Samplerate")]
                                [Validation(Required=false)]
                                public string Samplerate { get; set; }

                                /// <summary>
                                /// The start time.
                                /// </summary>
                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                /// <summary>
                                /// The time base.
                                /// </summary>
                                [NameInMap("Timebase")]
                                [Validation(Required=false)]
                                public string Timebase { get; set; }

                            }

                        }

                        /// <summary>
                        /// The list of subtitle streams.
                        /// </summary>
                        [NameInMap("SubtitleStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList : TeaModel {
                            [NameInMap("SubtitleStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                            public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                /// <summary>
                                /// The sequence number of the subtitle stream. The value indicates the position of the subtitle stream in all subtitle streams.
                                /// </summary>
                                [NameInMap("Index")]
                                [Validation(Required=false)]
                                public string Index { get; set; }

                                /// <summary>
                                /// The language. For more information, see [FFmpeg language definition](https://www.ffmpeg.org/ffmpeg-all.html#Metadata).
                                /// </summary>
                                [NameInMap("Lang")]
                                [Validation(Required=false)]
                                public string Lang { get; set; }

                            }

                        }

                        /// <summary>
                        /// The list of video streams.
                        /// </summary>
                        [NameInMap("VideoStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList VideoStreamList { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList : TeaModel {
                            [NameInMap("VideoStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                            public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream : TeaModel {
                                /// <summary>
                                /// The average frame rate.
                                /// </summary>
                                [NameInMap("AvgFPS")]
                                [Validation(Required=false)]
                                public string AvgFPS { get; set; }

                                /// <summary>
                                /// The bitrate.
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// The full name of the encoding format.
                                /// </summary>
                                [NameInMap("CodecLongName")]
                                [Validation(Required=false)]
                                public string CodecLongName { get; set; }

                                /// <summary>
                                /// The short name of the encoding format. Valid values: H264, mov, aac, avc, and mpeg.
                                /// </summary>
                                [NameInMap("CodecName")]
                                [Validation(Required=false)]
                                public string CodecName { get; set; }

                                /// <summary>
                                /// The tag of the encoding format.
                                /// </summary>
                                [NameInMap("CodecTag")]
                                [Validation(Required=false)]
                                public string CodecTag { get; set; }

                                /// <summary>
                                /// The tag string of the encoding format.
                                /// </summary>
                                [NameInMap("CodecTagString")]
                                [Validation(Required=false)]
                                public string CodecTagString { get; set; }

                                /// <summary>
                                /// The codec time base.
                                /// </summary>
                                [NameInMap("CodecTimeBase")]
                                [Validation(Required=false)]
                                public string CodecTimeBase { get; set; }

                                /// <summary>
                                /// The display aspect ratio (DAR) of the video stream.
                                /// </summary>
                                [NameInMap("Dar")]
                                [Validation(Required=false)]
                                public string Dar { get; set; }

                                /// <summary>
                                /// The duration.
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// The frame rate.
                                /// </summary>
                                [NameInMap("Fps")]
                                [Validation(Required=false)]
                                public string Fps { get; set; }

                                /// <summary>
                                /// Indicates whether the video stream contains bidirectional frames (B-frames). A value of **1** indicates that the video stream contains B-frames. A value of **2** indicates that the video stream does not contain B-frames.
                                /// </summary>
                                [NameInMap("HasBFrames")]
                                [Validation(Required=false)]
                                public string HasBFrames { get; set; }

                                /// <summary>
                                /// The latter number in the video resolution. The number indicates the video height.
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// The sequence number of the video stream. The value indicates the position of the video stream in all video streams.
                                /// </summary>
                                [NameInMap("Index")]
                                [Validation(Required=false)]
                                public string Index { get; set; }

                                /// <summary>
                                /// The language. For more information, see [FFmpeg documentation](https://www.ffmpeg.org/ffmpeg-all.html#Metadata).
                                /// </summary>
                                [NameInMap("Lang")]
                                [Validation(Required=false)]
                                public string Lang { get; set; }

                                /// <summary>
                                /// The codec level.
                                /// </summary>
                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                                /// <summary>
                                /// The network bandwidth consumption.
                                /// </summary>
                                [NameInMap("NetworkCost")]
                                [Validation(Required=false)]
                                public QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class QueryMediaListByURLResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                    /// <summary>
                                    /// The average bitrate of the video stream.
                                    /// </summary>
                                    [NameInMap("AvgBitrate")]
                                    [Validation(Required=false)]
                                    public string AvgBitrate { get; set; }

                                    /// <summary>
                                    /// The maximum bandwidth that was consumed.
                                    /// </summary>
                                    [NameInMap("CostBandwidth")]
                                    [Validation(Required=false)]
                                    public string CostBandwidth { get; set; }

                                    /// <summary>
                                    /// The amount of preload time.
                                    /// </summary>
                                    [NameInMap("PreloadTime")]
                                    [Validation(Required=false)]
                                    public string PreloadTime { get; set; }

                                }

                                /// <summary>
                                /// The total number of frames.
                                /// </summary>
                                [NameInMap("NumFrames")]
                                [Validation(Required=false)]
                                public string NumFrames { get; set; }

                                /// <summary>
                                /// The pixel format of the video stream.
                                /// </summary>
                                [NameInMap("PixFmt")]
                                [Validation(Required=false)]
                                public string PixFmt { get; set; }

                                /// <summary>
                                /// The codec profile.
                                /// </summary>
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }

                                /// <summary>
                                /// The rotation angle of the video.
                                /// </summary>
                                [NameInMap("Rotate")]
                                [Validation(Required=false)]
                                public string Rotate { get; set; }

                                /// <summary>
                                /// The sample aspect ratio (SAR).
                                /// </summary>
                                [NameInMap("Sar")]
                                [Validation(Required=false)]
                                public string Sar { get; set; }

                                /// <summary>
                                /// The start time.
                                /// </summary>
                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                /// <summary>
                                /// The time base.
                                /// </summary>
                                [NameInMap("Timebase")]
                                [Validation(Required=false)]
                                public string Timebase { get; set; }

                                /// <summary>
                                /// The former number in the video resolution. The number indicates the video width and cannot be negative.
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// The playlist.
                /// </summary>
                [NameInMap("PlayList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaPlayList PlayList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaPlayList : TeaModel {
                    [NameInMap("Play")]
                    [Validation(Required=false)]
                    public List<QueryMediaListByURLResponseBodyMediaListMediaPlayListPlay> Play { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaPlayListPlay : TeaModel {
                        /// <summary>
                        /// The name of the workflow activity.
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// The bitrate of the media file.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The duration.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// Indicates whether the media file is encrypted. Valid values:
                        /// 
                        /// *   **0**: The media file is not encrypted.
                        /// *   **1**: The media file is encrypted.
                        /// </summary>
                        [NameInMap("Encryption")]
                        [Validation(Required=false)]
                        public string Encryption { get; set; }

                        /// <summary>
                        /// The playback file.
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaPlayListPlayFile File { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaPlayListPlayFile : TeaModel {
                            /// <summary>
                            /// The status of the media file. Valid values:
                            /// 
                            /// *   **Normal**: The file is normal.
                            /// *   **Deleted**: The file is deleted.
                            /// </summary>
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            /// <summary>
                            /// The OSS URL of the playback file.
                            /// </summary>
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

                        /// <summary>
                        /// The encoding format of the media file. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// The frame rate.
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// The height of the media file.
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// The ID of the workflow that generates the playback file.
                        /// </summary>
                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        /// <summary>
                        /// The name of the workflow that generates the playback file.
                        /// </summary>
                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        /// <summary>
                        /// The size.
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        /// <summary>
                        /// The width.
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }

                /// <summary>
                /// The publishing status of the media file. Valid values:
                /// 
                /// - **Initiated**: The media file is in the initial state.
                /// - **UnPublish**: The media file has not been published, and the playback permission on the OSS object is Private.
                /// - **Published**: The media file has been published, and the playback permission on the OSS object is Default.
                /// - **Deleted**: The file is deleted.
                /// </summary>
                [NameInMap("PublishState")]
                [Validation(Required=false)]
                public string PublishState { get; set; }

                /// <summary>
                /// The IDs of the media workflow execution instances.
                /// </summary>
                [NameInMap("RunIdList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaRunIdList RunIdList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaRunIdList : TeaModel {
                    [NameInMap("RunId")]
                    [Validation(Required=false)]
                    public List<string> RunId { get; set; }

                }

                /// <summary>
                /// The size of the file.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// The list of snapshots.
                /// </summary>
                [NameInMap("SnapshotList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaSnapshotList SnapshotList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaSnapshotList : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshot> Snapshot { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshot : TeaModel {
                        /// <summary>
                        /// The name of the workflow activity that generates the snapshot.
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// The number of snapshots. This parameter is valid only when the value of the **Type** parameter is **Sequence**.
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// The snapshot.
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshotFile File { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaSnapshotListSnapshotFile : TeaModel {
                            /// <summary>
                            /// The status of the file. Valid values:
                            /// 
                            /// - **Normal**: The file is normal.
                            /// - **Deleted**: The file is deleted.
                            /// </summary>
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            /// <summary>
                            /// The OSS URL of the snapshot.
                            /// </summary>
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

                        /// <summary>
                        /// The ID of the workflow that generates the snapshot.
                        /// </summary>
                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        /// <summary>
                        /// The name of the workflow that generates the snapshot.
                        /// </summary>
                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        /// <summary>
                        /// The type of the snapshot. Valid values:
                        /// 
                        /// - **Single**: a single snapshot
                        /// - **Sequence**: snapshots in sequence
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The list of video summaries.
                /// </summary>
                [NameInMap("SummaryList")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaSummaryList SummaryList { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaSummaryList : TeaModel {
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummary> Summary { get; set; }
                    public class QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummary : TeaModel {
                        /// <summary>
                        /// The name of the workflow activity.
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// The information about the input file.
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummaryFile File { get; set; }
                        public class QueryMediaListByURLResponseBodyMediaListMediaSummaryListSummaryFile : TeaModel {
                            /// <summary>
                            /// The status of the media file. Valid values:
                            /// 
                            /// *   **Normal**: The file is normal.
                            /// *   **Deleted**: The file is deleted.
                            /// </summary>
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            /// <summary>
                            /// The OSS URL of the input file.
                            /// </summary>
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

                        /// <summary>
                        /// The ID of the workflow that generates the summary.
                        /// </summary>
                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        /// <summary>
                        /// The name of the workflow that generates the summary.
                        /// </summary>
                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        /// <summary>
                        /// The type of the summary. Valid values:
                        /// 
                        /// *   **Video**: video
                        /// *   **Gif**: dynamic image
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The tags of the media file.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public QueryMediaListByURLResponseBodyMediaListMediaTags Tags { get; set; }
                public class QueryMediaListByURLResponseBodyMediaListMediaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<string> Tag { get; set; }

                }

                /// <summary>
                /// The title.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The width.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        /// <summary>
        /// The IDs of the media files that do not exist. This parameter is not returned if all specified media files exist.
        /// </summary>
        [NameInMap("NonExistFileURLs")]
        [Validation(Required=false)]
        public QueryMediaListByURLResponseBodyNonExistFileURLs NonExistFileURLs { get; set; }
        public class QueryMediaListByURLResponseBodyNonExistFileURLs : TeaModel {
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public List<string> FileURL { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
