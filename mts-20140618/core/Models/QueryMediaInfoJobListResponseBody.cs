// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaInfoJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of each returned media information analysis job.</para>
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
                /// <para>Indicates whether the job is in asynchronous mode.</para>
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
                /// <para>The information about the job input.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobInput Input { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobInput : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket in which the input file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-bucket</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The ID of the OSS region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The name of the Object Storage Service (OSS) object that is used as the input file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.mp4</para>
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
                /// <para>The message sent by MNS to notify you of the job result.</para>
                /// </summary>
                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobMNSMessageResult : TeaModel {
                    /// <summary>
                    /// <para>The error code returned if the job failed. This parameter is not returned if the job is successful.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InvalidParameter.JsonObjectFormatInvalid</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The error message returned if the job failed. This parameter is not returned if the job is successful.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The parameter \&quot;Input\&quot; does not conform to the JSON Object specification</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The ID of the message returned if the job was successful. This parameter is not returned if the job fails.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
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
                /// <para>The ID of the MPS queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88c6ca184c0e432bbf5b665e2a15****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The information about the input file. For more information, see <a href="https://help.aliyun.com/document_detail/29251.html">AliyunProperties</a>.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobProperties Properties { get; set; }
                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobProperties : TeaModel {
                    /// <summary>
                    /// <para>The bitrate of the media file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1630.045</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The duration of the media file.</para>
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

                    [NameInMap("FileMd5")]
                    [Validation(Required=false)]
                    public string FileMd5 { get; set; }

                    /// <summary>
                    /// <para>The size of the image file.</para>
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
                    public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesFormat Format { get; set; }
                    public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesFormat : TeaModel {
                        /// <summary>
                        /// <para>The total bitrate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1630.045</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The total duration.</para>
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
                        /// <para>The short name of the container format.</para>
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
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("NumPrograms")]
                        [Validation(Required=false)]
                        public string NumPrograms { get; set; }

                        /// <summary>
                        /// <para>The total number of media streams.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("NumStreams")]
                        [Validation(Required=false)]
                        public string NumStreams { get; set; }

                        /// <summary>
                        /// <para>The size of the image file.</para>
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
                        /// <para>0.042000</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The frame rate of the media file.</para>
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
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The media streams that are contained in the input media file.</para>
                    /// </summary>
                    [NameInMap("Streams")]
                    [Validation(Required=false)]
                    public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreams Streams { get; set; }
                    public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreams : TeaModel {
                        /// <summary>
                        /// <para>The information about each audio stream.</para>
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
                                /// <para>The bitrate of the media file.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1536000</para>
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// <para>The number of sound channels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>5.1(side)</para>
                                /// </summary>
                                [NameInMap("ChannelLayout")]
                                [Validation(Required=false)]
                                public string ChannelLayout { get; set; }

                                /// <summary>
                                /// <para>The output layout of the sound channels.</para>
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
                                /// <para>DCA (DTS Coherent Acoustics)</para>
                                /// </summary>
                                [NameInMap("CodecLongName")]
                                [Validation(Required=false)]
                                public string CodecLongName { get; set; }

                                /// <summary>
                                /// <para>The short name of the encoding format. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>acc</b></description></item>
                                /// <item><description><b>mp3</b></description></item>
                                /// <item><description><b>mp4</b></description></item>
                                /// <item><description><b>ogg</b></description></item>
                                /// <item><description><b>flac</b></description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>acc</para>
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
                                /// <para>1/48000</para>
                                /// </summary>
                                [NameInMap("CodecTimeBase")]
                                [Validation(Required=false)]
                                public string CodecTimeBase { get; set; }

                                /// <summary>
                                /// <para>The duration of the media file.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>123</para>
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
                                /// <para>The language. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html?spm=a2c4g.11186623.2.66.243851cd2SntfN#Metadata">FFmpeg documentation</a>.</para>
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
                                /// <para>The sampling rate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>48000</para>
                                /// </summary>
                                [NameInMap("Samplerate")]
                                [Validation(Required=false)]
                                public string Samplerate { get; set; }

                                /// <summary>
                                /// <para>The start time.</para>
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
                                /// <para>1/1000</para>
                                /// </summary>
                                [NameInMap("Timebase")]
                                [Validation(Required=false)]
                                public string Timebase { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The information about each subtitle stream.</para>
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
                                /// <para>The duration. Unit: seconds.</para>
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
                                /// <para>The start time.</para>
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
                        /// <para>The information about each video stream.</para>
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
                                /// <para>The average frame rate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>24000/1001</para>
                                /// </summary>
                                [NameInMap("AvgFPS")]
                                [Validation(Required=false)]
                                public string AvgFPS { get; set; }

                                /// <summary>
                                /// <para>The bitrate of the media file.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>30541090</para>
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
                                /// <para>The display aspect ratio (DAR).</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>16:9</para>
                                /// </summary>
                                [NameInMap("Dar")]
                                [Validation(Required=false)]
                                public string Dar { get; set; }

                                /// <summary>
                                /// <para>The duration of the media file.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                [NameInMap("DurationInaccurate")]
                                [Validation(Required=false)]
                                public string DurationInaccurate { get; set; }

                                /// <summary>
                                /// <para>The frame rate of the media file.</para>
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
                                /// <para>The height of the video stream in pixels.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1080</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// <para>The sequence number of the video stream. The value indicates the position of the video stream in all video streams.</para>
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
                                public QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class QueryMediaInfoJobListResponseBodyMediaInfoJobListMediaInfoJobPropertiesStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                    /// <summary>
                                    /// <para>The average bitrate of the video stream.</para>
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
                                /// <para>180</para>
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
                                /// <para>The start time.</para>
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
                                /// <para>1/1000</para>
                                /// </summary>
                                [NameInMap("Timebase")]
                                [Validation(Required=false)]
                                public string Timebase { get; set; }

                                /// <summary>
                                /// <para>The width of the video in pixels.</para>
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
                    /// <para>1280</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>The status of the job.</para>
                /// <list type="bullet">
                /// <item><description><b>Analyzing</b>: The job is being run.</description></item>
                /// <item><description><b>Success</b>: The job is successful.</description></item>
                /// <item><description><b>Fail</b>: The job fails.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
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

        }

        /// <summary>
        /// <para>Nonexistent media information analysis jobs.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46A04AA5-B119-41BB-B750-7C5327AC3E7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
