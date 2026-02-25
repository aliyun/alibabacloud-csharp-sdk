// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitMediaInfoJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the media information analysis job.</para>
        /// </summary>
        [NameInMap("MediaInfoJob")]
        [Validation(Required=false)]
        public SubmitMediaInfoJobResponseBodyMediaInfoJob MediaInfoJob { get; set; }
        public class SubmitMediaInfoJobResponseBodyMediaInfoJob : TeaModel {
            /// <summary>
            /// <para>Indicates whether the job is run in asynchronous mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <para>The error code returned if the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter.JsonObjectFormatInvalid</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-01-10T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The information about the input media file.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobInput Input { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobInput : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket in which the input media file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-bucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The region in which the OSS bucket that stores the input media file resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-location</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The name of the OSS object that is used as the input media file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.flv</para>
                /// </summary>
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23ca1d184c0e4341e5b665e2a12****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The message sent by Message Service (MNS) to notify users of the job result.</para>
            /// </summary>
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobMNSMessageResult : TeaModel {
                /// <summary>
                /// <para>The error code that is returned if the job fails. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The parameter \&quot;Input\&quot; does not conform to the JSON Object specification</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message that is returned if the job fails. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter.JsonObjectFormatInvalid</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The ID of the message that is returned if the job is successful. This parameter is not returned if the job fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16f01ad6175e4230ac42bb5182cd****</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

            }

            /// <summary>
            /// <para>The error message returned if the job fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The parameter ”*” does not conform to the JSON Object specification</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the MPS queue to which the analysis job is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88c6ca184c0e432bbf5b665e2a15****</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The properties of the input media file.</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public SubmitMediaInfoJobResponseBodyMediaInfoJobProperties Properties { get; set; }
            public class SubmitMediaInfoJobResponseBodyMediaInfoJobProperties : TeaModel {
                /// <summary>
                /// <para>The bitrate. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1630.045</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The duration of the input media file. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17.226000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The format of the input media file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QuickTime/MOV</para>
                /// </summary>
                [NameInMap("FileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                /// <summary>
                /// <para>The size of the file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3509895</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// <para>The format information.</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesFormat Format { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesFormat : TeaModel {
                    /// <summary>
                    /// <para>The total bitrate. Unit: Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1630.045</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The duration of the input media file. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17.226000</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The full name of the container format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>QuickTime/MOV</para>
                    /// </summary>
                    [NameInMap("FormatLongName")]
                    [Validation(Required=false)]
                    public string FormatLongName { get; set; }

                    /// <summary>
                    /// <para>The short name of the container format. For more information about the parameters, see <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mov</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <para>The total number of program streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("NumPrograms")]
                    [Validation(Required=false)]
                    public string NumPrograms { get; set; }

                    /// <summary>
                    /// <para>The total number of media streams.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("NumStreams")]
                    [Validation(Required=false)]
                    public string NumStreams { get; set; }

                    /// <summary>
                    /// <para>The size of the file. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3509895</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public string Size { get; set; }

                    /// <summary>
                    /// <para>The start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.000000</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Tags { get; set; }

                }

                /// <summary>
                /// <para>The frame rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The height of the video. Unit: pixel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("MD5")]
                [Validation(Required=false)]
                public string MD5 { get; set; }

                /// <summary>
                /// <para>The media streams that are contained in the input media file.</para>
                /// </summary>
                [NameInMap("Streams")]
                [Validation(Required=false)]
                public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreams Streams { get; set; }
                public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreams : TeaModel {
                    [NameInMap("AudioStreamList")]
                    [Validation(Required=false)]
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamList AudioStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamList : TeaModel {
                        [NameInMap("AudioStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsAudioStreamListAudioStream : TeaModel {
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

                            [NameInMap("DurationInaccurate")]
                            [Validation(Required=false)]
                            public string DurationInaccurate { get; set; }

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
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamList : TeaModel {
                        [NameInMap("SubtitleStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                    public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamList VideoStreamList { get; set; }
                    public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamList : TeaModel {
                        [NameInMap("VideoStream")]
                        [Validation(Required=false)]
                        public List<SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                        public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStream : TeaModel {
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

                            [NameInMap("DolbyVision")]
                            [Validation(Required=false)]
                            public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamDolbyVision DolbyVision { get; set; }
                            public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamDolbyVision : TeaModel {
                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }

                            }

                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("DurationInaccurate")]
                            [Validation(Required=false)]
                            public string DurationInaccurate { get; set; }

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
                            public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                            public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
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

                /// <summary>
                /// <para>The width of the video. Unit: pixel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1920</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: The job is successful.</description></item>
            /// <item><description><b>Fail</b>: The job fails.</description></item>
            /// <item><description><b>Analyzing</b>: The job is being run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Analyzing</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The custom data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testid-001</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62D9BE16-B7D5-550C-A482-7A0F60E09877</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
