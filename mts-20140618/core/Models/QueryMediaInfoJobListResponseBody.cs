// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaInfoJobListResponseBody : TeaModel {
        /// <summary>
        /// The details of each returned media information analysis job.
        /// </summary>
        [NameInMap("MediaInfoJobList")]
        [Validation(Required=false)]
        public QueryMediaInfoJobListResponseBodyMediaInfoJobList MediaInfoJobList { get; set; }
        public class QueryMediaInfoJobListResponseBodyMediaInfoJobList : TeaModel {
            [NameInMap("MediaInfoJob")]
            [Validation(Required=false)]
            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJob> MediaInfoJob { get; set; }
            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJob : TeaModel {
                /// <summary>
                /// Indicates whether the job is in asynchronous mode.
                /// </summary>
                [NameInMap("Async")]
                [Validation(Required=false)]
                public bool? Async { get; set; }

                /// <summary>
                /// The error code returned if the job fails.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The time when the job was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The information about the job input.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobInput Input { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobInput : TeaModel {
                    /// <summary>
                    /// The OSS bucket in which the input file is stored.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The ID of the OSS region.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The name of the Object Storage Service (OSS) object that is used as the input file.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// The ID of the job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The message sent by MNS to notify you of the job result.
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobMNSMessageResult : TeaModel {
                    /// <summary>
                    /// The error code returned if the job failed. This parameter is not returned if the job is successful.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// The error message returned if the job failed. This parameter is not returned if the job is successful.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// The ID of the message returned if the job was successful. This parameter is not returned if the job fails.
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }

                /// <summary>
                /// The error message returned if the job fails.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the MPS queue.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The information about the input file. For more information, see [AliyunProperties](https://help.aliyun.com/document_detail/29251.html).
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobProperties Properties { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobProperties : TeaModel {
                    /// <summary>
                    /// The bitrate of the media file.
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// The duration of the media file.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// The format of the input media file.
                    /// </summary>
                    [NameInMap("FileFormat")]
                    [Validation(Required=false)]
                    public string FileFormat { get; set; }

                    /// <summary>
                    /// The size of the image file.
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// The format information.
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesFormat Format { get; set; }
                    public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesFormat : TeaModel {
                        /// <summary>
                        /// The total bitrate.
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// The total duration.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// The full name of the container format.
                        /// </summary>
                        [NameInMap("FormatLongName")]
                        [Validation(Required=false)]
                        public string FormatLongName { get; set; }

                        /// <summary>
                        /// The short name of the container format.
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
                        /// The size of the image file.
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
                    /// The frame rate of the media file.
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// The height of the video. Unit: pixel.
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// The media streams that are contained in the input media file.
                    /// </summary>
                    [NameInMap("Streams")]
                    [Validation(Required=false)]
                    public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreams Streams { get; set; }
                    public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreams : TeaModel {
                        /// <summary>
                        /// The information about each audio stream.
                        /// </summary>
                        [NameInMap("AudioStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                        public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamList : TeaModel {
                            [NameInMap("AudioStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                                /// <summary>
                                /// The bitrate of the media file.
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// The number of sound channels.
                                /// </summary>
                                [NameInMap("ChannelLayout")]
                                [Validation(Required=false)]
                                public string ChannelLayout { get; set; }

                                /// <summary>
                                /// The output layout of the sound channels.
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
                                /// The short name of the encoding format. Valid values:
                                /// 
                                /// *   **acc**
                                /// *   **mp3**
                                /// *   **mp4**
                                /// *   **ogg**
                                /// *   **flac**
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
                                /// The language. For more information, see [FFmpeg documentation](https://www.ffmpeg.org/ffmpeg-all.html?spm=a2c4g.11186623.2.66.243851cd2SntfN#Metadata).
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
                        /// The information about each subtitle stream.
                        /// </summary>
                        [NameInMap("SubtitleStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                        public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamList : TeaModel {
                            [NameInMap("SubtitleStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                                /// <summary>
                                /// The full name of the encoding format.
                                /// </summary>
                                [NameInMap("CodecLongName")]
                                [Validation(Required=false)]
                                public string CodecLongName { get; set; }

                                /// <summary>
                                /// The short name of the encoding format. Valid values:
                                /// 
                                /// *   **srt**
                                /// *   **ass**
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
                                /// The duration. Unit: seconds.
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// The sequence number of the subtitle stream. The value indicates the position of the subtitle stream in all subtitle streams.
                                /// </summary>
                                [NameInMap("Index")]
                                [Validation(Required=false)]
                                public string Index { get; set; }

                                /// <summary>
                                /// The language.
                                /// </summary>
                                [NameInMap("Lang")]
                                [Validation(Required=false)]
                                public string Lang { get; set; }

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
                        /// The information about each video stream.
                        /// </summary>
                        [NameInMap("VideoStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                        public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamList : TeaModel {
                            [NameInMap("VideoStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                                /// <summary>
                                /// The average frame rate.
                                /// </summary>
                                [NameInMap("AvgFPS")]
                                [Validation(Required=false)]
                                public string AvgFPS { get; set; }

                                /// <summary>
                                /// The bitrate of the media file.
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
                                /// The short name of the encoding format. Valid values:
                                /// 
                                /// *   **h264**
                                /// *   **h265**
                                /// *   **gif**
                                /// *   **webp**
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
                                /// The level of color reconstruction.
                                /// </summary>
                                [NameInMap("ColorPrimaries")]
                                [Validation(Required=false)]
                                public string ColorPrimaries { get; set; }

                                /// <summary>
                                /// The color range.
                                /// </summary>
                                [NameInMap("ColorRange")]
                                [Validation(Required=false)]
                                public string ColorRange { get; set; }

                                /// <summary>
                                /// The color channel.
                                /// </summary>
                                [NameInMap("ColorTransfer")]
                                [Validation(Required=false)]
                                public string ColorTransfer { get; set; }

                                /// <summary>
                                /// The display aspect ratio (DAR).
                                /// </summary>
                                [NameInMap("Dar")]
                                [Validation(Required=false)]
                                public string Dar { get; set; }

                                /// <summary>
                                /// The duration of the media file.
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// The frame rate of the media file.
                                /// </summary>
                                [NameInMap("Fps")]
                                [Validation(Required=false)]
                                public string Fps { get; set; }

                                /// <summary>
                                /// Indicates whether the video stream contains bidirectional frames (B-frames). A value of 1 indicates that the video stream contains B-frames. A value of 0 indicates that the video stream does not contain B-frames.
                                /// </summary>
                                [NameInMap("HasBFrames")]
                                [Validation(Required=false)]
                                public string HasBFrames { get; set; }

                                /// <summary>
                                /// The height of the video stream in pixels.
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
                                /// The language.
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
                                /// The network bandwidth that is consumed.
                                /// </summary>
                                [NameInMap("NetworkCost")]
                                [Validation(Required=false)]
                                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                    /// <summary>
                                    /// The average bitrate of the video stream.
                                    /// </summary>
                                    [NameInMap("AvgBitrate")]
                                    [Validation(Required=false)]
                                    public string AvgBitrate { get; set; }

                                    /// <summary>
                                    /// The maximum bandwidth that is consumed.
                                    /// </summary>
                                    [NameInMap("CostBandwidth")]
                                    [Validation(Required=false)]
                                    public string CostBandwidth { get; set; }

                                    /// <summary>
                                    /// The time consumed to preload the video.
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
                                /// The pixel format.
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
                                /// The width of the video in pixels.
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// The width of the video. Unit: pixel.
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// The status of the job.
                /// 
                /// *   **Analyzing**: The job is being run.
                /// *   **Success**: The job is successful.
                /// *   **Fail**: The job fails.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The custom data.
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        /// <summary>
        /// Nonexistent media information analysis jobs.
        /// </summary>
        [NameInMap("NonExistMediaInfoJobIds")]
        [Validation(Required=false)]
        public QueryMediaInfoJobListResponseBodyNonExistMediaInfoJobIds NonExistMediaInfoJobIds { get; set; }
        public class QueryMediaInfoJobListResponseBodyNonExistMediaInfoJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
