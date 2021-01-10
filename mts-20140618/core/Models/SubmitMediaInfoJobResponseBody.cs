// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitMediaInfoJobResponseBody : TeaModel {
        [NameInMap("MediaInfoJob")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobResponseBodyMediaInfoJob MediaInfoJob { get; set; }
        public class SubmitMediaInfoJobResponseBodyMediaInfoJob : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobInput Input { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobInput : TeaModel {
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobMNSMessageResult : TeaModel {
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
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobProperties Properties { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobProperties : TeaModel {
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("FileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                [NameInMap("Streams")]
                [Validation(Required=false)]
                public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreams Streams { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreams : TeaModel {
                    [NameInMap("VideoStreamList")]
                    [Validation(Required=false)]
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamList : TeaModel {
                        [NameInMap("VideoStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStream : TeaModel {
                            [NameInMap("Sar")]
                            [Validation(Required=false)]
                            public string Sar { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            [NameInMap("NetworkCost")]
                            [Validation(Required=false)]
                            public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                            public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                [NameInMap("PreloadTime")]
                                [Validation(Required=false)]
                                public string PreloadTime { get; set; }
                                [NameInMap("AvgBitrate")]
                                [Validation(Required=false)]
                                public string AvgBitrate { get; set; }
                                [NameInMap("CostBandwidth")]
                                [Validation(Required=false)]
                                public string CostBandwidth { get; set; }
                            };

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                            [NameInMap("AvgFPS")]
                            [Validation(Required=false)]
                            public string AvgFPS { get; set; }

                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            [NameInMap("NumFrames")]
                            [Validation(Required=false)]
                            public string NumFrames { get; set; }

                            [NameInMap("Rotate")]
                            [Validation(Required=false)]
                            public string Rotate { get; set; }

                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("HasBFrames")]
                            [Validation(Required=false)]
                            public string HasBFrames { get; set; }

                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("Dar")]
                            [Validation(Required=false)]
                            public string Dar { get; set; }

                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                        }

                    }
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamList : TeaModel {
                        [NameInMap("AudioStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamListAudioStream : TeaModel {
                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            [NameInMap("SampleFmt")]
                            [Validation(Required=false)]
                            public string SampleFmt { get; set; }

                            [NameInMap("ChannelLayout")]
                            [Validation(Required=false)]
                            public string ChannelLayout { get; set; }

                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            [NameInMap("NumFrames")]
                            [Validation(Required=false)]
                            public string NumFrames { get; set; }

                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                        }

                    }
                    [NameInMap("SubtitleStreamList")]
                    [Validation(Required=false)]
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamList : TeaModel {
                        [NameInMap("SubtitleStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                        }

                    }
                };

                [NameInMap("Format")]
                [Validation(Required=false)]
                public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesFormat Format { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesFormat : TeaModel {
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }
                    [NameInMap("NumPrograms")]
                    [Validation(Required=false)]
                    public string NumPrograms { get; set; }
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public string Size { get; set; }
                    [NameInMap("NumStreams")]
                    [Validation(Required=false)]
                    public string NumStreams { get; set; }
                    [NameInMap("FormatLongName")]
                    [Validation(Required=false)]
                    public string FormatLongName { get; set; }
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }
                };

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
