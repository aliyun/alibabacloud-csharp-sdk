// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the media asset.</para>
        /// </summary>
        [NameInMap("MediaInfo")]
        [Validation(Required=false)]
        public GetMediaInfoResponseBodyMediaInfo MediaInfo { get; set; }
        public class GetMediaInfoResponseBodyMediaInfo : TeaModel {
            /// <summary>
            /// <para>The raw data from the AI analysis.</para>
            /// </summary>
            [NameInMap("AiRoughData")]
            [Validation(Required=false)]
            public GetMediaInfoResponseBodyMediaInfoAiRoughData AiRoughData { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoAiRoughData : TeaModel {
                /// <summary>
                /// <para>The AI category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Lifestyle</para>
                /// </description></item>
                /// <item><description><para>Appearance</para>
                /// </description></item>
                /// <item><description><para>Pets</para>
                /// </description></item>
                /// <item><description><para>News</para>
                /// </description></item>
                /// <item><description><para>Advertisement</para>
                /// </description></item>
                /// <item><description><para>Environment</para>
                /// </description></item>
                /// <item><description><para>Automobile</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>生活</para>
                /// </summary>
                [NameInMap("AiCategory")]
                [Validation(Required=false)]
                public string AiCategory { get; set; }

                /// <summary>
                /// <para>The AI job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>483915d4f2cd8ac20b48fb04</b></b></para>
                /// </summary>
                [NameInMap("AiJobId")]
                [Validation(Required=false)]
                public string AiJobId { get; set; }

                /// <summary>
                /// <para>The raw AI analysis result.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://sample-bucket.cn-shanghai.aliyuncs.com/result.json">https://sample-bucket.cn-shanghai.aliyuncs.com/result.json</a></para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The save type. Specifies whether to save the results to the search index after the AI analysis is complete. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TEXT: The text index.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TEXT</para>
                /// </summary>
                [NameInMap("SaveType")]
                [Validation(Required=false)]
                public string SaveType { get; set; }

                /// <summary>
                /// <para>The tag job.</para>
                /// </summary>
                [NameInMap("StandardSmartTagJob")]
                [Validation(Required=false)]
                public GetMediaInfoResponseBodyMediaInfoAiRoughDataStandardSmartTagJob StandardSmartTagJob { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoAiRoughDataStandardSmartTagJob : TeaModel {
                    /// <summary>
                    /// <para>The AI job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><b><b>483915d4f2cd8ac20b48fb04</b></b></para>
                    /// </summary>
                    [NameInMap("AiJobId")]
                    [Validation(Required=false)]
                    public string AiJobId { get; set; }

                    /// <summary>
                    /// <para>The tag result URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xx.oss-cn-shanghai.aliyuncs.com/result2.txt">http://xx.oss-cn-shanghai.aliyuncs.com/result2.txt</a></para>
                    /// </summary>
                    [NameInMap("ResultUrl")]
                    [Validation(Required=false)]
                    public string ResultUrl { get; set; }

                    /// <summary>
                    /// <para>A list of tag recognition results.</para>
                    /// </summary>
                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public List<GetMediaInfoResponseBodyMediaInfoAiRoughDataStandardSmartTagJobResults> Results { get; set; }
                    public class GetMediaInfoResponseBodyMediaInfoAiRoughDataStandardSmartTagJobResults : TeaModel {
                        /// <summary>
                        /// <para>The detailed analysis result is a JSON string. For the data structure of each Type, see <a href="~~478787#api-detail-40~~">Result parameter description</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;autoChapters&quot;: [...]}</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                        /// <summary>
                        /// <para>The tag identification type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>NLP: The result from Natural Language Processing (NLP).</para>
                        /// </description></item>
                        /// <item><description><para>TextLabel: A text tag.</para>
                        /// </description></item>
                        /// <item><description><para>VideoLabel: A video tag.</para>
                        /// </description></item>
                        /// <item><description><para>ASR: The raw result from Automatic Speech Recognition (ASR).</para>
                        /// </description></item>
                        /// <item><description><para>OCR: The raw result from Optical Character Recognition (OCR).</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NLP</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The AI analysis status:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Analyzing</b>: The analysis is in progress.</para>
                    /// </description></item>
                    /// <item><description><para><b>AnalyzeSuccess</b>: The analysis is successful.</para>
                    /// </description></item>
                    /// <item><description><para><b>AnalyzeFailed</b>: The analysis failed.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Analyzing</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The status of the AI analysis:</para>
                /// <list type="bullet">
                /// <item><description><para>Analyzing: The analysis is in progress.</para>
                /// </description></item>
                /// <item><description><para>AnalyzeSuccess: The analysis is successful.</para>
                /// </description></item>
                /// <item><description><para>AnalyzeFailed: The analysis failed.</para>
                /// </description></item>
                /// <item><description><para>Saving: The data is being saved.</para>
                /// </description></item>
                /// <item><description><para>SaveSuccess: The data is saved.</para>
                /// </description></item>
                /// <item><description><para>SaveFailed: The data failed to save.</para>
                /// </description></item>
                /// <item><description><para>Deleting: The data is being deleted.</para>
                /// </description></item>
                /// <item><description><para>DeleteSuccess: The data is deleted.</para>
                /// </description></item>
                /// <item><description><para>DeleteFailed: The data failed to delete.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Analyzing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>A list of file information objects.</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetMediaInfoResponseBodyMediaInfoFileInfoList> FileInfoList { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoFileInfoList : TeaModel {
                /// <summary>
                /// <para>A list of audio stream information. A media asset may contain multiple audio streams.</para>
                /// </summary>
                [NameInMap("AudioStreamInfoList")]
                [Validation(Required=false)]
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList> AudioStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListAudioStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The bitrate, in kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>127.794</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The channel layout.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>stereo</para>
                    /// </summary>
                    [NameInMap("ChannelLayout")]
                    [Validation(Required=false)]
                    public string ChannelLayout { get; set; }

                    /// <summary>
                    /// <para>The number of audio channels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public string Channels { get; set; }

                    /// <summary>
                    /// <para>The full name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AAC (Advanced Audio Coding)</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <para>The short name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aac</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <para>The tag of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x6134706d</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The tag string of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mp4a</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <para>The time base of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/24000</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16.200998</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The audio frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>The index of the audio stream.</para>
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
                    /// <para>und</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <para>The total number of audio frames.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("NumFrames")]
                    [Validation(Required=false)]
                    public string NumFrames { get; set; }

                    /// <summary>
                    /// <para>The encoding profile.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>High</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <para>The sample format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fltp</para>
                    /// </summary>
                    [NameInMap("SampleFmt")]
                    [Validation(Required=false)]
                    public string SampleFmt { get; set; }

                    /// <summary>
                    /// <para>The sample rate, in Hz.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public string SampleRate { get; set; }

                    /// <summary>
                    /// <para>The start time, in seconds.</para>
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

                /// <summary>
                /// <para>The basic information about the file, such as the duration and size.</para>
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public GetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <para>The file bitrate in kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1132.68</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The time when the file was created. The time is in UTC and follows the <c>YYYY-MM-DDTHH:MM:SSZ</c> format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-26T04:11:08Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The file duration in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>216.206667</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The name of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.mp4</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The file size in bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30611502</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <para>The status of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// <para>The type of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source_file</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <para>The file\&quot;s OSS URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>The container format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mov,mp4,m4a,3gp,3g2,mj2</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <para>The video height in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>540</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The time when the file was last modified. The time is in UTC and follows the <c>YYYY-MM-DDTHH:MM:SSZ</c> format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-26T04:11:10Z</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    /// <summary>
                    /// <para>The Region where the file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The video width in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>960</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                /// <summary>
                /// <para>A list of subtitle stream information. A media asset may contain multiple subtitle streams.</para>
                /// </summary>
                [NameInMap("SubtitleStreamInfoList")]
                [Validation(Required=false)]
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList> SubtitleStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListSubtitleStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The full name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SubRip Text</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <para>The short name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>srt</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <para>The tag of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unicode</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The tag string of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unicode</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <para>The time base of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>29.97</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The index of the subtitle stream.</para>
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
                    /// <para>und</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <para>The start time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                }

                /// <summary>
                /// <para>A list of video stream information. A media asset may contain multiple video streams.</para>
                /// </summary>
                [NameInMap("VideoStreamInfoList")]
                [Validation(Required=false)]
                public List<GetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList> VideoStreamInfoList { get; set; }
                public class GetMediaInfoResponseBodyMediaInfoFileInfoListVideoStreamInfoList : TeaModel {
                    /// <summary>
                    /// <para>The average frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24.0</para>
                    /// </summary>
                    [NameInMap("AvgFPS")]
                    [Validation(Required=false)]
                    public string AvgFPS { get; set; }

                    /// <summary>
                    /// <para>The bitrate, in kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1001.594</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The full name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                    /// </summary>
                    [NameInMap("CodecLongName")]
                    [Validation(Required=false)]
                    public string CodecLongName { get; set; }

                    /// <summary>
                    /// <para>The short name of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>h264</para>
                    /// </summary>
                    [NameInMap("CodecName")]
                    [Validation(Required=false)]
                    public string CodecName { get; set; }

                    /// <summary>
                    /// <para>The tag of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0x0000</para>
                    /// </summary>
                    [NameInMap("CodecTag")]
                    [Validation(Required=false)]
                    public string CodecTag { get; set; }

                    /// <summary>
                    /// <para>The tag string of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[0][0][0][0]</para>
                    /// </summary>
                    [NameInMap("CodecTagString")]
                    [Validation(Required=false)]
                    public string CodecTagString { get; set; }

                    /// <summary>
                    /// <para>The time base of the codec.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/48</para>
                    /// </summary>
                    [NameInMap("CodecTimeBase")]
                    [Validation(Required=false)]
                    public string CodecTimeBase { get; set; }

                    /// <summary>
                    /// <para>The display aspect ratio (DAR).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Dar")]
                    [Validation(Required=false)]
                    public string Dar { get; set; }

                    /// <summary>
                    /// <para>The duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>216.206706</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The video frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24.0</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>Specifies whether B-frames exist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("HasBFrames")]
                    [Validation(Required=false)]
                    public string HasBFrames { get; set; }

                    /// <summary>
                    /// <para>The video height in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>540</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The index of the video stream.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <para>The language.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>und</para>
                    /// </summary>
                    [NameInMap("Lang")]
                    [Validation(Required=false)]
                    public string Lang { get; set; }

                    /// <summary>
                    /// <para>The encoding level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The total number of video frames.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5184</para>
                    /// </summary>
                    [NameInMap("Nb_frames")]
                    [Validation(Required=false)]
                    public string NbFrames { get; set; }

                    /// <summary>
                    /// <para>The total number of frames.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5184</para>
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
                    /// <para>The encoding profile.</para>
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
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Rotate")]
                    [Validation(Required=false)]
                    public string Rotate { get; set; }

                    /// <summary>
                    /// <para>The sample aspect ratio (SAR).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0:1</para>
                    /// </summary>
                    [NameInMap("Sar")]
                    [Validation(Required=false)]
                    public string Sar { get; set; }

                    /// <summary>
                    /// <para>The start time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.081706</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The time base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1/12288</para>
                    /// </summary>
                    [NameInMap("Timebase")]
                    [Validation(Required=false)]
                    public string Timebase { get; set; }

                    /// <summary>
                    /// <para>The video width in pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>960</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>Basic information about the media asset.</para>
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetMediaInfoResponseBodyMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetMediaInfoResponseBodyMediaInfoMediaBasicInfo : TeaModel {
                /// <summary>
                /// <para>The business associated with the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ICE</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <para>The business type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3048</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cateName</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The category of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Category</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The cover image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the media asset was created. The time is in UTC and follows the <c>YYYY-MM-DDTHH:MM:SSZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the media asset was deleted. The time is in UTC and follows the <c>YYYY-MM-DDTHH:MM:SSZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:15Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <para>The description of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The media asset URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <para>The media asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>A comma-separated list of tags for the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// <para>The media asset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The time when the media asset was last modified. The time is in UTC and follows the <c>YYYY-MM-DDTHH:MM:SSZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:10Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>A custom, user-unique ID. It must be 6 to 64 characters long and can only contain letters, digits, hyphens (-), and underscores (_).</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-1234</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <para>A list of snapshot URLs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     &quot;<a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/snapshot-00001.png?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/snapshot-00001.png?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken>&quot;,
                ///     &quot;<a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/snapshot-00002.jpg?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/snapshot-00002.jpg?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken>&quot;,
                ///     &quot;<a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/snapshot-00003.jpg?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/snapshot-00003.jpg?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken>&quot;
                /// ]</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <para>The source of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The details of the generated sprite images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;32&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>83ec44d58b2069def2e</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-shanghai&quot;,&quot;snapshotRegular&quot;:&quot;example/example-{Count}.jpg&quot;,&quot;spriteRegular&quot;:&quot;example/example-{TileCount}.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e438b14ff39293eaec25</b></b></b>&quot;,&quot;tileCount&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                /// <summary>
                /// <para>The status of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The title of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The upload source of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                /// <summary>
                /// <para>Custom user data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userDataTest</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The media asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FDE2411-DB8D-4A9A-875B-275798F14A5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
