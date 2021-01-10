// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitVideoPoseJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoPoseJob")]
        [Validation(Required=false)]
        public SubmitVideoPoseJobResponseBodyVideoPoseJob VideoPoseJob { get; set; }
        public class SubmitVideoPoseJobResponseBodyVideoPoseJob : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitVideoPoseJobResponseBodyVideoPoseJobInput Input { get; set; }
            public class SubmitVideoPoseJobResponseBodyVideoPoseJobInput : TeaModel {
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
            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public SubmitVideoPoseJobResponseBodyVideoPoseJobOutputConfig OutputConfig { get; set; }
            public class SubmitVideoPoseJobResponseBodyVideoPoseJobOutputConfig : TeaModel {
                [NameInMap("VideoFile")]
                [Validation(Required=false)]
                public SubmitVideoPoseJobResponseBodyVideoPoseJobOutputConfigVideoFile VideoFile { get; set; }
                public class SubmitVideoPoseJobResponseBodyVideoPoseJobOutputConfigVideoFile : TeaModel {
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

                [NameInMap("DataFile")]
                [Validation(Required=false)]
                public SubmitVideoPoseJobResponseBodyVideoPoseJobOutputConfigDataFile DataFile { get; set; }
                public class SubmitVideoPoseJobResponseBodyVideoPoseJobOutputConfigDataFile : TeaModel {
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

            }
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public SubmitVideoPoseJobResponseBodyVideoPoseJobProperties Properties { get; set; }
            public class SubmitVideoPoseJobResponseBodyVideoPoseJobProperties : TeaModel {
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                [NameInMap("FileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                [NameInMap("Streams")]
                [Validation(Required=false)]
                public SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreams Streams { get; set; }
                public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreams : TeaModel {
                    [NameInMap("VideoStreamList")]
                    [Validation(Required=false)]
                    public SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                    public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsVideoStreamList : TeaModel {
                        [NameInMap("VideoStream")]
                        [Validation(Required=false)]
                        public List<SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                        public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("HasBFrames")]
                            [Validation(Required=false)]
                            public string HasBFrames { get; set; }

                            [NameInMap("Sar")]
                            [Validation(Required=false)]
                            public string Sar { get; set; }

                            [NameInMap("Dar")]
                            [Validation(Required=false)]
                            public string Dar { get; set; }

                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            [NameInMap("AvgFPS")]
                            [Validation(Required=false)]
                            public string AvgFPS { get; set; }

                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("NumFrames")]
                            [Validation(Required=false)]
                            public string NumFrames { get; set; }

                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                            [NameInMap("Rotate")]
                            [Validation(Required=false)]
                            public string Rotate { get; set; }

                            [NameInMap("NetworkCost")]
                            [Validation(Required=false)]
                            public SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                            public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                [NameInMap("PreloadTime")]
                                [Validation(Required=false)]
                                public string PreloadTime { get; set; }
                                [NameInMap("CostBandwidth")]
                                [Validation(Required=false)]
                                public string CostBandwidth { get; set; }
                                [NameInMap("AvgBitrate")]
                                [Validation(Required=false)]
                                public string AvgBitrate { get; set; }
                            };

                        }

                    }
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                    public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsAudioStreamList : TeaModel {
                        [NameInMap("AudioStream")]
                        [Validation(Required=false)]
                        public List<SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                        public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            [NameInMap("SampleFmt")]
                            [Validation(Required=false)]
                            public string SampleFmt { get; set; }

                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            [NameInMap("ChannelLayout")]
                            [Validation(Required=false)]
                            public string ChannelLayout { get; set; }

                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("NumFrames")]
                            [Validation(Required=false)]
                            public string NumFrames { get; set; }

                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                        }

                    }
                    [NameInMap("SubtitleStreamList")]
                    [Validation(Required=false)]
                    public SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                    public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsSubtitleStreamList : TeaModel {
                        [NameInMap("SubtitleStream")]
                        [Validation(Required=false)]
                        public List<SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                        public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                        }

                    }
                };

                [NameInMap("Format")]
                [Validation(Required=false)]
                public SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesFormat Format { get; set; }
                public class SubmitVideoPoseJobResponseBodyVideoPoseJobPropertiesFormat : TeaModel {
                    [NameInMap("NumStreams")]
                    [Validation(Required=false)]
                    public string NumStreams { get; set; }
                    [NameInMap("NumPrograms")]
                    [Validation(Required=false)]
                    public string NumPrograms { get; set; }
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }
                    [NameInMap("FormatLongName")]
                    [Validation(Required=false)]
                    public string FormatLongName { get; set; }
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public string Size { get; set; }
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }
                };

            }
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitVideoPoseJobResponseBodyVideoPoseJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitVideoPoseJobResponseBodyVideoPoseJobMNSMessageResult : TeaModel {
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

            }
        };

    }

}
