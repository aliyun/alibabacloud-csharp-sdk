// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaInfoJobListResponseBody : TeaModel {
        [NameInMap("MediaInfoJobList")]
        [Validation(Required=false)]
        public QueryMediaInfoJobListResponseBodyMediaInfoJobList MediaInfoJobList { get; set; }
        public class QueryMediaInfoJobListResponseBodyMediaInfoJobList : TeaModel {
            [NameInMap("MediaInfoJob")]
            [Validation(Required=false)]
            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJob> MediaInfoJob { get; set; }
            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJob : TeaModel {
                public bool? Async { get; set; }
                public string Code { get; set; }
                public string CreationTime { get; set; }
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobInput Input { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobInput : TeaModel {
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
                public string JobId { get; set; }
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobMNSMessageResult : TeaModel {
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
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobProperties Properties { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobProperties : TeaModel {
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
                    public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesFormat Format { get; set; }
                    public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesFormat : TeaModel {
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
                    public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreams Streams { get; set; }
                    public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreams : TeaModel {
                        [NameInMap("AudioStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                        public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamList : TeaModel {
                            [NameInMap("AudioStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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
                        public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                        public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamList : TeaModel {
                            [NameInMap("SubtitleStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
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

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Timebase")]
                                [Validation(Required=false)]
                                public string Timebase { get; set; }

                            }

                        }
                        [NameInMap("VideoStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                        public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamList : TeaModel {
                            [NameInMap("VideoStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                            public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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

                                [NameInMap("ColorPrimaries")]
                                [Validation(Required=false)]
                                public string ColorPrimaries { get; set; }

                                [NameInMap("ColorRange")]
                                [Validation(Required=false)]
                                public string ColorRange { get; set; }

                                [NameInMap("ColorTransfer")]
                                [Validation(Required=false)]
                                public string ColorTransfer { get; set; }

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
                                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }
                public string State { get; set; }
                public string UserData { get; set; }
            }
        };

        [NameInMap("NonExistMediaInfoJobIds")]
        [Validation(Required=false)]
        public QueryMediaInfoJobListResponseBodyNonExistMediaInfoJobIds NonExistMediaInfoJobIds { get; set; }
        public class QueryMediaInfoJobListResponseBodyNonExistMediaInfoJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
