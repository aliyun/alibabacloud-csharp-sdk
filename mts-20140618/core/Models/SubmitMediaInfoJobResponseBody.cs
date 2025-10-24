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
                    /// <summary>
                    /// <para>The audio streams. A media file can contain up to four audio streams.</para>
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
                            /// <para>The bitrate. Unit: Kbit/s.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>128.806</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <para>The output layout of the sound channels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>stereo</para>
                            /// </summary>
                            [NameInMap("ChannelLayout")]
                            [Validation(Required=false)]
                            public string ChannelLayout { get; set; }

                            /// <summary>
                            /// <para>The number of sound channels.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            /// <summary>
                            /// <para>The full name of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AAC (Advanced Audio Coding)</para>
                            /// </summary>
                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            /// <summary>
                            /// <para>The short name of the encoding format. Default value: acc. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>acc</b></description></item>
                            /// <item><description><b>mp3</b></description></item>
                            /// <item><description><b>mp4</b></description></item>
                            /// <item><description><b>ogg</b></description></item>
                            /// <item><description><b>flac</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>aac</para>
                            /// </summary>
                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            /// <summary>
                            /// <para>The tag of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0x6134706d</para>
                            /// </summary>
                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            /// <summary>
                            /// <para>The tag string of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>mp4a</para>
                            /// </summary>
                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            /// <summary>
                            /// <para>The codec time base.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1/44100</para>
                            /// </summary>
                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            /// <summary>
                            /// <para>The duration of the audio stream. Unit: seconds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>17.159546</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("DurationInaccurate")]
                            [Validation(Required=false)]
                            public string DurationInaccurate { get; set; }

                            /// <summary>
                            /// <para>The sequence number of the audio stream. The value indicates the position of the audio stream in all audio streams.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            /// <summary>
                            /// <para>The language.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>eng</para>
                            /// </summary>
                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                            /// <summary>
                            /// <para>The total number of frames.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>123</para>
                            /// </summary>
                            [NameInMap("NumFrames")]
                            [Validation(Required=false)]
                            public string NumFrames { get; set; }

                            /// <summary>
                            /// <para>The sampling format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>fltp</para>
                            /// </summary>
                            [NameInMap("SampleFmt")]
                            [Validation(Required=false)]
                            public string SampleFmt { get; set; }

                            /// <summary>
                            /// <para>The sampling rate. Unit: Hz.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>44100</para>
                            /// </summary>
                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            /// <summary>
                            /// <para>The start time of the audio stream.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.000000</para>
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            /// <summary>
                            /// <para>The time base.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1/44100</para>
                            /// </summary>
                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The subtitle streams. A media file can contain up to four subtitle streams.</para>
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
                            /// <para>The full name of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ASS (Advanced SSA) subtitle</para>
                            /// </summary>
                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            /// <summary>
                            /// <para>The short name of the encoding format. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>srt</b></description></item>
                            /// <item><description><b>ass</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ass</para>
                            /// </summary>
                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            /// <summary>
                            /// <para>The tag of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0x0000</para>
                            /// </summary>
                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            /// <summary>
                            /// <para>The tag string of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>[0][0][0][0]</para>
                            /// </summary>
                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            /// <summary>
                            /// <para>The codec time base.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0/1</para>
                            /// </summary>
                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            /// <summary>
                            /// <para>The duration of the audio stream. Unit: seconds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1370.116000</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// <para>The sequence number of the subtitle stream. The value indicates the position of the subtitle stream in all subtitle streams.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            /// <summary>
                            /// <para>The language.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>eng</para>
                            /// </summary>
                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                            /// <summary>
                            /// <para>The start time of the subtitle stream.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.000000</para>
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            /// <summary>
                            /// <para>The time base.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1/1000</para>
                            /// </summary>
                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The video streams. A media file can contain up to four video streams.</para>
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
                            /// <para>The average frame rate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>23.976025</para>
                            /// </summary>
                            [NameInMap("AvgFPS")]
                            [Validation(Required=false)]
                            public string AvgFPS { get; set; }

                            /// <summary>
                            /// <para>The bitrate. Unit: Kbit/s.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1496.46</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <para>The full name of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>H.264/AVC/MPEG-4 AVC/MPEG-4 part 10</para>
                            /// </summary>
                            [NameInMap("CodecLongName")]
                            [Validation(Required=false)]
                            public string CodecLongName { get; set; }

                            /// <summary>
                            /// <para>The short name of the encoding format. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>h264</b></description></item>
                            /// <item><description><b>h265</b></description></item>
                            /// <item><description><b>gif</b></description></item>
                            /// <item><description><b>webp</b></description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>h264</para>
                            /// </summary>
                            [NameInMap("CodecName")]
                            [Validation(Required=false)]
                            public string CodecName { get; set; }

                            /// <summary>
                            /// <para>The tag of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0x31637661</para>
                            /// </summary>
                            [NameInMap("CodecTag")]
                            [Validation(Required=false)]
                            public string CodecTag { get; set; }

                            /// <summary>
                            /// <para>The tag string of the encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>avc1</para>
                            /// </summary>
                            [NameInMap("CodecTagString")]
                            [Validation(Required=false)]
                            public string CodecTagString { get; set; }

                            /// <summary>
                            /// <para>The codec time base.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1001/48000</para>
                            /// </summary>
                            [NameInMap("CodecTimeBase")]
                            [Validation(Required=false)]
                            public string CodecTimeBase { get; set; }

                            /// <summary>
                            /// <para>The level of color reconstruction.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>700</para>
                            /// </summary>
                            [NameInMap("ColorPrimaries")]
                            [Validation(Required=false)]
                            public string ColorPrimaries { get; set; }

                            /// <summary>
                            /// <para>The color range.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>700</para>
                            /// </summary>
                            [NameInMap("ColorRange")]
                            [Validation(Required=false)]
                            public string ColorRange { get; set; }

                            /// <summary>
                            /// <para>The color channel.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>R255 G83 B170</para>
                            /// </summary>
                            [NameInMap("ColorTransfer")]
                            [Validation(Required=false)]
                            public string ColorTransfer { get; set; }

                            /// <summary>
                            /// <para>The display aspect ratio (DAR). DAR is the proportional relationship between the width and the height of a video. The value is used to determine whether the video is in portrait mode or landscape mode.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16:9</para>
                            /// </summary>
                            [NameInMap("Dar")]
                            [Validation(Required=false)]
                            public string Dar { get; set; }

                            /// <summary>
                            /// <para>The duration of the video stream. Unit: seconds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>17.225542</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("DurationInaccurate")]
                            [Validation(Required=false)]
                            public string DurationInaccurate { get; set; }

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
                            /// <para>Indicates whether the video stream contains bidirectional frames (B-frames). A value of 1 indicates that the video stream contains B-frames. A value of 0 indicates that the video stream does not contain B-frames.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("HasBFrames")]
                            [Validation(Required=false)]
                            public string HasBFrames { get; set; }

                            /// <summary>
                            /// <para>The height of the video. Unit: pixel.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1080</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The sequence number of the video stream. The value indicates the position of the video stream in all video streams. The sequence number of the first video stream to be played can be specified in some players. Default value: 1.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Index")]
                            [Validation(Required=false)]
                            public string Index { get; set; }

                            /// <summary>
                            /// <para>The language.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>eng</para>
                            /// </summary>
                            [NameInMap("Lang")]
                            [Validation(Required=false)]
                            public string Lang { get; set; }

                            /// <summary>
                            /// <para>The codec level.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>41</para>
                            /// </summary>
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }

                            /// <summary>
                            /// <para>The network bandwidth that is consumed.</para>
                            /// </summary>
                            [NameInMap("NetworkCost")]
                            [Validation(Required=false)]
                            public SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                            public class SubmitMediaInfoJobResponseBodyMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                /// <summary>
                                /// <para>The average bitrate. Unit: Kbit/s.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>300.34</para>
                                /// </summary>
                                [NameInMap("AvgBitrate")]
                                [Validation(Required=false)]
                                public string AvgBitrate { get; set; }

                                /// <summary>
                                /// <para>The maximum bandwidth that is consumed.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("CostBandwidth")]
                                [Validation(Required=false)]
                                public string CostBandwidth { get; set; }

                                /// <summary>
                                /// <para>The time consumed to preload the video.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>8</para>
                                /// </summary>
                                [NameInMap("PreloadTime")]
                                [Validation(Required=false)]
                                public string PreloadTime { get; set; }

                            }

                            /// <summary>
                            /// <para>The total number of frames.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("NumFrames")]
                            [Validation(Required=false)]
                            public string NumFrames { get; set; }

                            /// <summary>
                            /// <para>The pixel format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>yuv420p</para>
                            /// </summary>
                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            /// <summary>
                            /// <para>The codec profile.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>High</para>
                            /// </summary>
                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            /// <summary>
                            /// <para>The rotation angle of the video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>90</para>
                            /// </summary>
                            [NameInMap("Rotate")]
                            [Validation(Required=false)]
                            public string Rotate { get; set; }

                            /// <summary>
                            /// <para>The sample aspect ratio (SAR).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1:1</para>
                            /// </summary>
                            [NameInMap("Sar")]
                            [Validation(Required=false)]
                            public string Sar { get; set; }

                            /// <summary>
                            /// <para>The start time of the video stream.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.042000</para>
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                            /// <summary>
                            /// <para>The time base.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1/24000</para>
                            /// </summary>
                            [NameInMap("Timebase")]
                            [Validation(Required=false)]
                            public string Timebase { get; set; }

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
