// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitMediaInfoJobResponseBody : TeaModel {
        /// <summary>
        /// The details of the media information analysis job.
        /// </summary>
        [NameInMap("MediaInfoJob")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobResponseBodyMediaInfoJob MediaInfoJob { get; set; }
        public class SubmitMediaInfoJobResponseBodyMediaInfoJob : TeaModel {
            /// <summary>
            /// Indicates whether the job is run in asynchronous mode.
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
            /// The information about the input media file.
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobInput Input { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobInput : TeaModel {
                /// <summary>
                /// The name of the OSS bucket in which the input media file is stored.
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// The region in which the OSS bucket that stores the input media file resides.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the OSS object that is used as the input media file.
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
            /// The message sent by Message Service (MNS) to notify users of the job result.
            /// </summary>
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobMNSMessageResult : TeaModel {
                /// <summary>
                /// The error code that is returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message that is returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The ID of the message that is returned if the job is successful. This parameter is not returned if the job fails.
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
            /// The ID of the MPS queue to which the analysis job is submitted.
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// The properties of the input media file.
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobProperties Properties { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobProperties : TeaModel {
                /// <summary>
                /// The bitrate. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The duration of the input media file. Unit: seconds.
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
                /// The size of the file. Unit: bytes.
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// The format information.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesFormat Format { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesFormat : TeaModel {
                    /// <summary>
                    /// The total bitrate. Unit: Kbit/s.
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// The duration of the input media file. Unit: seconds.
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
                    /// The short name of the container format. For more information about the parameters, see [Parameter details](https://www.alibabacloud.com/help/zh/apsaravideo-for-media-processing/latest/parameter-details-a).
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
                    /// The size of the file. Unit: bytes.
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
                /// The frame rate.
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
                public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreams Streams { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreams : TeaModel {
                    /// <summary>
                    /// The audio streams. A media file can contain up to four audio streams.
                    /// </summary>
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamList : TeaModel {
                        [NameInMap("AudioStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                            /// <summary>
                            /// The bitrate. Unit: Kbit/s.
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
                            /// The short name of the encoding format. Default value: acc. Valid values:
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
                            /// The duration of the audio stream. Unit: seconds.
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
                            /// The language.
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
                            /// The sampling rate. Unit: Hz.
                            /// </summary>
                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            /// <summary>
                            /// The start time of the audio stream.
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
                    /// The subtitle streams. A media file can contain up to four subtitle streams.
                    /// </summary>
                    [NameInMap("SubtitleStreamList")]
                    [Validation(Required=false)]
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamList : TeaModel {
                        [NameInMap("SubtitleStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                            /// The duration of the audio stream. Unit: seconds.
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
                            /// The start time of the subtitle stream.
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
                    /// The video streams. A media file can contain up to four video streams.
                    /// </summary>
                    [NameInMap("VideoStreamList")]
                    [Validation(Required=false)]
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamList : TeaModel {
                        [NameInMap("VideoStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                            /// <summary>
                            /// The average frame rate.
                            /// </summary>
                            [NameInMap("AvgFPS")]
                            [Validation(Required=false)]
                            public string AvgFPS { get; set; }

                            /// <summary>
                            /// The bitrate. Unit: Kbit/s.
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
                            /// The display aspect ratio (DAR). DAR is the proportional relationship between the width and the height of a video. The value is used to determine whether the video is in portrait mode or landscape mode.
                            /// </summary>
                            [NameInMap("Dar")]
                            [Validation(Required=false)]
                            public string Dar { get; set; }

                            /// <summary>
                            /// The duration of the video stream. Unit: seconds.
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
                            /// Indicates whether the video stream contains bidirectional frames (B-frames). A value of 1 indicates that the video stream contains B-frames. A value of 0 indicates that the video stream does not contain B-frames.
                            /// </summary>
                            [NameInMap("HasBFrames")]
                            [Validation(Required=false)]
                            public string HasBFrames { get; set; }

                            /// <summary>
                            /// The height of the video. Unit: pixel.
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// The sequence number of the video stream. The value indicates the position of the video stream in all video streams. The sequence number of the first video stream to be played can be specified in some players. Default value: 1.
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
                            public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                            public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                /// <summary>
                                /// The average bitrate. Unit: Kbit/s.
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
                            /// The start time of the video stream.
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
                            /// The width of the video. Unit: pixel.
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
            /// The status of the job. Valid values:
            /// 
            /// *   **Success**: The job is successful.
            /// *   **Fail**: The job fails.
            /// *   **Analyzing**: The job is being run.
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
