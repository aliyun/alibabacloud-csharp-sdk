// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of media files.</para>
        /// </summary>
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public QueryMediaListResponseBodyMediaList MediaList { get; set; }
        public class QueryMediaListResponseBodyMediaList : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public List<QueryMediaListResponseBodyMediaListMedia> Media { get; set; }
            public class QueryMediaListResponseBodyMediaListMedia : TeaModel {
                /// <summary>
                /// <para>The bitrate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2659.326</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The ID of the category to which the media file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The review status of the media file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Initiated</b>: The media file is uploaded but not reviewed.</description></item>
                /// <item><description><b>Pass</b>: The media file is uploaded and passes the review.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Initiated</para>
                /// </summary>
                [NameInMap("CensorState")]
                [Validation(Required=false)]
                public string CensorState { get; set; }

                /// <summary>
                /// <para>The OSS URL of the thumbnail.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket1-****.oss-cn-hangzhou.aliyuncs.com//example-****.png">http://example-bucket1-****.oss-cn-hangzhou.aliyuncs.com//example-****.png</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the media file was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-09-14T08:30:33Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description ****</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.965000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The details of the input file.</para>
                /// </summary>
                [NameInMap("File")]
                [Validation(Required=false)]
                public QueryMediaListResponseBodyMediaListMediaFile File { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaFile : TeaModel {
                    /// <summary>
                    /// <para>The status of the input file. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Normal</b>: normal</description></item>
                    /// <item><description><b>Deleted</b>: deleted</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    /// <summary>
                    /// <para>The OSS URL of the input file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4</a></para>
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

                /// <summary>
                /// <para>The encoding format. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mov</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The frame rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25.0</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The height of the media file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The ID of the media file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3e1cd21131a94525be55acf65888****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The media information.</para>
                /// </summary>
                [NameInMap("MediaInfo")]
                [Validation(Required=false)]
                public QueryMediaListResponseBodyMediaListMediaMediaInfo MediaInfo { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaMediaInfo : TeaModel {
                    /// <summary>
                    /// <para>The format information.</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public QueryMediaListResponseBodyMediaListMediaMediaInfoFormat Format { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaMediaInfoFormat : TeaModel {
                        /// <summary>
                        /// <para>The bitrate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2659.326</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The total duration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7.965000</para>
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
                        /// <para>The short name of the container format. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.</para>
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
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("NumStreams")]
                        [Validation(Required=false)]
                        public string NumStreams { get; set; }

                        /// <summary>
                        /// <para>The size of the file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2647692</para>
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
                    /// <para>The stream information.</para>
                    /// </summary>
                    [NameInMap("Streams")]
                    [Validation(Required=false)]
                    public QueryMediaListResponseBodyMediaListMediaMediaInfoStreams Streams { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreams : TeaModel {
                        /// <summary>
                        /// <para>The list of audio streams.</para>
                        /// </summary>
                        [NameInMap("AudioStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList AudioStreamList { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamList : TeaModel {
                            [NameInMap("AudioStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream> AudioStream { get; set; }
                            public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsAudioStreamListAudioStream : TeaModel {
                                /// <summary>
                                /// <para>The bitrate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>160.008</para>
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
                                /// <para>AAC(Advanced Audio Coding)</para>
                                /// </summary>
                                [NameInMap("CodecLongName")]
                                [Validation(Required=false)]
                                public string CodecLongName { get; set; }

                                /// <summary>
                                /// <para>The short name of the encoding format. Valid values: H264, mov, aac, avc, and mpeg.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>mov</para>
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
                                /// <para>The duration.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>182.591995</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

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
                                /// <para>The language. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html#Metadata">FFmpeg documentation</a>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>und</para>
                                /// </summary>
                                [NameInMap("Lang")]
                                [Validation(Required=false)]
                                public string Lang { get; set; }

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
                                /// <para>44100</para>
                                /// </summary>
                                [NameInMap("Samplerate")]
                                [Validation(Required=false)]
                                public string Samplerate { get; set; }

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
                                /// <para>1/44100</para>
                                /// </summary>
                                [NameInMap("Timebase")]
                                [Validation(Required=false)]
                                public string Timebase { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The list of subtitle streams.</para>
                        /// </summary>
                        [NameInMap("SubtitleStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList SubtitleStreamList { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamList : TeaModel {
                            [NameInMap("SubtitleStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream> SubtitleStream { get; set; }
                            public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsSubtitleStreamListSubtitleStream : TeaModel {
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
                                /// <para>The language. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html#Metadata">FFmpeg documentation</a>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>und</para>
                                /// </summary>
                                [NameInMap("Lang")]
                                [Validation(Required=false)]
                                public string Lang { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The list of video streams.</para>
                        /// </summary>
                        [NameInMap("VideoStreamList")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList VideoStreamList { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamList : TeaModel {
                            [NameInMap("VideoStream")]
                            [Validation(Required=false)]
                            public List<QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream> VideoStream { get; set; }
                            public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStream : TeaModel {
                                /// <summary>
                                /// <para>The average frame rate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>29.97003</para>
                                /// </summary>
                                [NameInMap("AvgFPS")]
                                [Validation(Required=false)]
                                public string AvgFPS { get; set; }

                                /// <summary>
                                /// <para>The bitrate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2659.326</para>
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// <para>The full name of the encoding format.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>QuickTime/MOV</para>
                                /// </summary>
                                [NameInMap("CodecLongName")]
                                [Validation(Required=false)]
                                public string CodecLongName { get; set; }

                                /// <summary>
                                /// <para>The short name of the encoding format. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>mov</para>
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
                                /// <para>1001/60000</para>
                                /// </summary>
                                [NameInMap("CodecTimeBase")]
                                [Validation(Required=false)]
                                public string CodecTimeBase { get; set; }

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
                                /// <para>The duration.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>182.683000</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The frame rate.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>29.97003</para>
                                /// </summary>
                                [NameInMap("Fps")]
                                [Validation(Required=false)]
                                public string Fps { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the video stream contains bidirectional frames (B-frames). A value of <b>1</b> indicates that the video stream contains B-frames. A value of <b>2</b> indicates that the video stream does not contain B-frames.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("HasBFrames")]
                                [Validation(Required=false)]
                                public string HasBFrames { get; set; }

                                /// <summary>
                                /// <para>The latter number in the video resolution. The number indicates the video height.</para>
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
                                /// <para>5</para>
                                /// </summary>
                                [NameInMap("Index")]
                                [Validation(Required=false)]
                                public string Index { get; set; }

                                /// <summary>
                                /// <para>The language. For more information, see <a href="https://www.ffmpeg.org/ffmpeg-all.html#Metadata">FFmpeg documentation</a>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>und</para>
                                /// </summary>
                                [NameInMap("Lang")]
                                [Validation(Required=false)]
                                public string Lang { get; set; }

                                /// <summary>
                                /// <para>The codec level.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>40</para>
                                /// </summary>
                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                                /// <summary>
                                /// <para>The network bandwidth consumption.</para>
                                /// </summary>
                                [NameInMap("NetworkCost")]
                                [Validation(Required=false)]
                                public QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost NetworkCost { get; set; }
                                public class QueryMediaListResponseBodyMediaListMediaMediaInfoStreamsVideoStreamListVideoStreamNetworkCost : TeaModel {
                                    /// <summary>
                                    /// <para>The average bitrate.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2659.326</para>
                                    /// </summary>
                                    [NameInMap("AvgBitrate")]
                                    [Validation(Required=false)]
                                    public string AvgBitrate { get; set; }

                                    /// <summary>
                                    /// <para>The maximum bandwidth that was consumed.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>100</para>
                                    /// </summary>
                                    [NameInMap("CostBandwidth")]
                                    [Validation(Required=false)]
                                    public string CostBandwidth { get; set; }

                                    /// <summary>
                                    /// <para>The amount of preload time.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0.01</para>
                                    /// </summary>
                                    [NameInMap("PreloadTime")]
                                    [Validation(Required=false)]
                                    public string PreloadTime { get; set; }

                                }

                                /// <summary>
                                /// <para>The total number of frames.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>12</para>
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
                                /// <para>The video rotation angle.</para>
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
                                /// <para>1/30000</para>
                                /// </summary>
                                [NameInMap("Timebase")]
                                [Validation(Required=false)]
                                public string Timebase { get; set; }

                                /// <summary>
                                /// <para>The former number in the video resolution. The number indicates the video width.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public string Width { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <para>The playlist.</para>
                /// </summary>
                [NameInMap("PlayList")]
                [Validation(Required=false)]
                public QueryMediaListResponseBodyMediaListMediaPlayList PlayList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaPlayList : TeaModel {
                    [NameInMap("Play")]
                    [Validation(Required=false)]
                    public List<QueryMediaListResponseBodyMediaListMediaPlayListPlay> Play { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaPlayListPlay : TeaModel {
                        /// <summary>
                        /// <para>The name of the workflow activity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-activity-****</para>
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// <para>The bitrate of the media file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2659.326</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The duration of the media file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7.965000</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the media file is encrypted. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>: The media file is not encrypted.</description></item>
                        /// <item><description><b>1</b>: The media file is encrypted.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Encryption")]
                        [Validation(Required=false)]
                        public string Encryption { get; set; }

                        /// <summary>
                        /// <para>The playback file.</para>
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaPlayListPlayFile File { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaPlayListPlayFile : TeaModel {
                            /// <summary>
                            /// <para>The status of the file. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>Normal</b>: normal</description></item>
                            /// <item><description><b>Deleted</b>: deleted</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Normal</para>
                            /// </summary>
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            /// <summary>
                            /// <para>The Object Storage Service (OSS) URL of the output file.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4</a></para>
                            /// </summary>
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

                        /// <summary>
                        /// <para>The encoding format of the media file. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mp4</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The frame rate of the media file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>25.0</para>
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// <para>The height.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1080</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The ID of the workflow that generates the playback file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>93ab850b4f6f44eab54b6e91d24d****</para>
                        /// </summary>
                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        /// <summary>
                        /// <para>The name of the workflow that generates the playback file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-mediaworkflow-****</para>
                        /// </summary>
                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        /// <summary>
                        /// <para>The size of the media file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2647692</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        /// <summary>
                        /// <para>The width of the media file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>760</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }

                /// <summary>
                /// <para>The publishing status of the media file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Initiated</b>: The media file is in the initial state.</description></item>
                /// <item><description><b>UnPublish</b>: The media file has not been published, and the playback permission on the OSS object is Private.</description></item>
                /// <item><description><b>Published</b>: The media file has been published, and the playback permission on the OSS object is Default.</description></item>
                /// <item><description><b>Deleted</b>: The media file has been deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("PublishState")]
                [Validation(Required=false)]
                public string PublishState { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// </summary>
                [NameInMap("RunIdList")]
                [Validation(Required=false)]
                public QueryMediaListResponseBodyMediaListMediaRunIdList RunIdList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaRunIdList : TeaModel {
                    [NameInMap("RunId")]
                    [Validation(Required=false)]
                    public List<string> RunId { get; set; }

                }

                /// <summary>
                /// <para>The size of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2647692</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <para>The list of snapshots.</para>
                /// </summary>
                [NameInMap("SnapshotList")]
                [Validation(Required=false)]
                public QueryMediaListResponseBodyMediaListMediaSnapshotList SnapshotList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaSnapshotList : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshot> Snapshot { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshot : TeaModel {
                        /// <summary>
                        /// <para>The name of the workflow activity that generates the snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-activity1-****</para>
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// <para>The number of snapshots. This parameter is valid only when the value of the <b>Type</b> parameter is <b>Sequence</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        /// <summary>
                        /// <para>The snapshot.</para>
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshotFile File { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaSnapshotListSnapshotFile : TeaModel {
                            /// <summary>
                            /// <para>The status of the file. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>Normal</b>: normal</description></item>
                            /// <item><description><b>Deleted</b>: deleted</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Normal</para>
                            /// </summary>
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            /// <summary>
                            /// <para>The OSS URL of the snapshot.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://example1-bucket1-****.oss-cn-hangzhou.aliyuncs.com//example111-****.png">http://example1-bucket1-****.oss-cn-hangzhou.aliyuncs.com//example111-****.png</a></para>
                            /// </summary>
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID of the workflow that generates the snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6cc3aa66d1cb4bb2adf14e726c0a****</para>
                        /// </summary>
                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        /// <summary>
                        /// <para>The name of the workflow that generates the snapshot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-workflow-****</para>
                        /// </summary>
                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        /// <summary>
                        /// <para>The type of the snapshot. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Single</b></description></item>
                        /// <item><description><b>Sequence</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sequence</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The list of video summaries.</para>
                /// </summary>
                [NameInMap("SummaryList")]
                [Validation(Required=false)]
                public QueryMediaListResponseBodyMediaListMediaSummaryList SummaryList { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaSummaryList : TeaModel {
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public List<QueryMediaListResponseBodyMediaListMediaSummaryListSummary> Summary { get; set; }
                    public class QueryMediaListResponseBodyMediaListMediaSummaryListSummary : TeaModel {
                        /// <summary>
                        /// <para>The name of the workflow activity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-activity-****</para>
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// <para>The information about the input file.</para>
                        /// </summary>
                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public QueryMediaListResponseBodyMediaListMediaSummaryListSummaryFile File { get; set; }
                        public class QueryMediaListResponseBodyMediaListMediaSummaryListSummaryFile : TeaModel {
                            /// <summary>
                            /// <para>The status of the file. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>Normal</b>: normal</description></item>
                            /// <item><description><b>Deleted</b>: deleted</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Normal</para>
                            /// </summary>
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            /// <summary>
                            /// <para>The OSS URL of the input file.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4</a></para>
                            /// </summary>
                            [NameInMap("URL")]
                            [Validation(Required=false)]
                            public string URL { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID of the workflow that generates the summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>93ab850b4f6f44eab54b6e91d24d****</para>
                        /// </summary>
                        [NameInMap("MediaWorkflowId")]
                        [Validation(Required=false)]
                        public string MediaWorkflowId { get; set; }

                        /// <summary>
                        /// <para>The name of the workflow that generates the summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-mediaworkflow-****</para>
                        /// </summary>
                        [NameInMap("MediaWorkflowName")]
                        [Validation(Required=false)]
                        public string MediaWorkflowName { get; set; }

                        /// <summary>
                        /// <para>The type of the summary. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Video</b>: video</description></item>
                        /// <item><description><b>Gif</b>: dynamic image</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Video</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The tags of the media file.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public QueryMediaListResponseBodyMediaListMediaTags Tags { get; set; }
                public class QueryMediaListResponseBodyMediaListMediaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<string> Tag { get; set; }

                }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-title-****</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1920</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The IDs of the media files that do not exist. This parameter is not returned when all specified media files exist.</para>
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public QueryMediaListResponseBodyNonExistMediaIds NonExistMediaIds { get; set; }
        public class QueryMediaListResponseBodyNonExistMediaIds : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>283DC68C-146F-4489-A2A1-2F88F1472A56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
