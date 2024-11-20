// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTranscodeJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of jobs.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListTranscodeJobsResponseBodyJobs> Jobs { get; set; }
        public class ListTranscodeJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The time when the job was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job was complete. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The input group of the job. An input of a single file indicates a transcoding job. An input of multiple files indicates an audio and video stream merge job.</para>
            /// </summary>
            [NameInMap("InputGroup")]
            [Validation(Required=false)]
            public List<ListTranscodeJobsResponseBodyJobsInputGroup> InputGroup { get; set; }
            public class ListTranscodeJobsResponseBodyJobsInputGroup : TeaModel {
                /// <summary>
                /// <para>The URL of the media asset. This parameter is specified only when the media asset is transcoded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("InputUrl")]
                [Validation(Required=false)]
                public string InputUrl { get; set; }

                /// <summary>
                /// <para>The media object.</para>
                /// <list type="bullet">
                /// <item><description>If Type is set to OSS, the URL of an OSS object is returned. Both the OSS and HTTP protocols are supported.</description></item>
                /// <item><description>If Type is set to Media, the ID of a media asset is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the media object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
                /// <item><description>Media: a media asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The number of subjobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("JobCount")]
            [Validation(Required=false)]
            public int? JobCount { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>transcode-job</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output group of the job.</para>
            /// </summary>
            [NameInMap("OutputGroup")]
            [Validation(Required=false)]
            public List<ListTranscodeJobsResponseBodyJobsOutputGroup> OutputGroup { get; set; }
            public class ListTranscodeJobsResponseBodyJobsOutputGroup : TeaModel {
                /// <summary>
                /// <para>The output file configuration.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public ListTranscodeJobsResponseBodyJobsOutputGroupOutput Output { get; set; }
                public class ListTranscodeJobsResponseBodyJobsOutputGroupOutput : TeaModel {
                    /// <summary>
                    /// <para>The media object. If Type is set to OSS, the URL of an OSS object is returned. Both the OSS and HTTP protocols are supported. If Type is set to Media, the ID of a media asset is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// <para>The URL of the transcoded output stream. This parameter is required only when the output is a media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/{MediaId}/{JobId}.mp4</para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                    /// <summary>
                    /// <para>The type of the media object. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>OSS: an OSS object.</description></item>
                    /// <item><description>Media: a media asset.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OSS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The job processing configuration.</para>
                /// </summary>
                [NameInMap("ProcessConfig")]
                [Validation(Required=false)]
                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfig ProcessConfig { get; set; }
                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfig : TeaModel {
                    /// <summary>
                    /// <para>The multi-input stream merge configuration.</para>
                    /// </summary>
                    [NameInMap("CombineConfigs")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigCombineConfigs> CombineConfigs { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigCombineConfigs : TeaModel {
                        /// <summary>
                        /// <para>The audio stream index.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0 或 exclude</para>
                        /// </summary>
                        [NameInMap("AudioIndex")]
                        [Validation(Required=false)]
                        public string AudioIndex { get; set; }

                        /// <summary>
                        /// <para>The duration of the input stream. The default value is the duration of the video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20.0</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public double? Duration { get; set; }

                        /// <summary>
                        /// <para>The start time of the input stream. Default value: 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public double? Start { get; set; }

                        /// <summary>
                        /// <para>The video stream index.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0 或 exclude</para>
                        /// </summary>
                        [NameInMap("VideoIndex")]
                        [Validation(Required=false)]
                        public string VideoIndex { get; set; }

                    }

                    /// <summary>
                    /// <para>The encryption settings.</para>
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigEncryption Encryption { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigEncryption : TeaModel {
                        /// <summary>
                        /// <para>The ciphertext of HTTP Live Streaming (HLS) encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MTYi00NDU0LTg5O****</para>
                        /// </summary>
                        [NameInMap("CipherText")]
                        [Validation(Required=false)]
                        public string CipherText { get; set; }

                        /// <summary>
                        /// <para>The endpoint of the decryption service for HLS encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://sample.com/path?CipherText=MTYi00NDU0LTg5O">https://sample.com/path?CipherText=MTYi00NDU0LTg5O</a>****</para>
                        /// </summary>
                        [NameInMap("DecryptKeyUri")]
                        [Validation(Required=false)]
                        public string DecryptKeyUri { get; set; }

                        /// <summary>
                        /// <para>The encryption type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrivateEncryption</para>
                        /// </summary>
                        [NameInMap("EncryptType")]
                        [Validation(Required=false)]
                        public string EncryptType { get; set; }

                    }

                    /// <summary>
                    /// <para>The watermark configuration for an image.</para>
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The position of the watermark on the x-axis.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            /// <summary>
                            /// <para>The position of the watermark on the y-axis.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }

                            /// <summary>
                            /// <para>The watermark image file.</para>
                            /// </summary>
                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// <para>The media object. If Type is set to OSS, the URL of an OSS object is returned. Both the OSS and HTTP protocols are supported. If Type is set to Media, the ID of a media asset is returned.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>oss://bucket/path/to/video.mp4</para>
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// <para>The type of the media object. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>OSS: an OSS object.</description></item>
                                /// <item><description>Media: a media asset.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>OSS</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                            /// <summary>
                            /// <para>The height of the output video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>32</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The reference position of the watermark. Valid values: TopLeft, TopRight, BottomLeft, and BottomRight. Default value: TopLeft.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TopLeft</para>
                            /// </summary>
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            /// <summary>
                            /// <para>The timeline settings.</para>
                            /// </summary>
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                /// <summary>
                                /// <para>The duration of the stream. Valid values: the number of seconds or &quot;ToEND&quot;.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ToEND</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The beginning of the time range for which data was queried.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00:00:05</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }

                            /// <summary>
                            /// <para>The width of the output video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>32</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                        /// <summary>
                        /// <para>The template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the tags of the input stream are inherited in the output stream. This parameter does not take effect when the input is not a media asset. Default value: false.</para>
                    /// </summary>
                    [NameInMap("IsInheritTags")]
                    [Validation(Required=false)]
                    public bool? IsInheritTags { get; set; }

                    /// <summary>
                    /// <para>The subtitle configuration.</para>
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The file encoding format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>UTF-8</para>
                            /// </summary>
                            [NameInMap("CharEnc")]
                            [Validation(Required=false)]
                            public string CharEnc { get; set; }

                            /// <summary>
                            /// <para>The subtitle file.</para>
                            /// </summary>
                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// <para>The media object.</para>
                                /// <list type="bullet">
                                /// <item><description>If Type is set to OSS, the URL of an OSS object is returned. Both the OSS and HTTP protocols are supported.</description></item>
                                /// <item><description>If Type is set to Media, the ID of a media asset is returned.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>oss://bucket/path/to/video.mp4</para>
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// <para>The type of the media object. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>OSS: an OSS object.</description></item>
                                /// <item><description>Media: a media asset.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>OSS</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                            /// <summary>
                            /// <para>The format of the subtitle file.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vtt</para>
                            /// </summary>
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }

                        /// <summary>
                        /// <para>The template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of the text watermarks.</para>
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the text size was adjusted based on the output video dimensions. true / false, default: false</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }

                            /// <summary>
                            /// <para>The border color.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }

                            /// <summary>
                            /// <para>The border width.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("BorderWidth")]
                            [Validation(Required=false)]
                            public int? BorderWidth { get; set; }

                            /// <summary>
                            /// <para>The watermark text. Base64 encoding is not required. The string must be encoded in UTF-8.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>测试水印</para>
                            /// </summary>
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The transparency of the watermark.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.0</para>
                            /// </summary>
                            [NameInMap("FontAlpha")]
                            [Validation(Required=false)]
                            public string FontAlpha { get; set; }

                            /// <summary>
                            /// <para>The color of the text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("FontColor")]
                            [Validation(Required=false)]
                            public string FontColor { get; set; }

                            /// <summary>
                            /// <para>The font of the text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SimSun</para>
                            /// </summary>
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }

                            /// <summary>
                            /// <para>The size of the text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }

                            /// <summary>
                            /// <para>The distance of the watermark from the left edge.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public string Left { get; set; }

                            /// <summary>
                            /// <para>The distance of the watermark from the top edge.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Top")]
                            [Validation(Required=false)]
                            public string Top { get; set; }

                        }

                        /// <summary>
                        /// <para>The template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// <para>The transcoding configuration.</para>
                    /// </summary>
                    [NameInMap("Transcode")]
                    [Validation(Required=false)]
                    public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscode Transcode { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscode : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The audio settings.</para>
                            /// </summary>
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                                /// <summary>
                                /// <para>The audio bitrate of the output file.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [8,1000].</description></item>
                                /// <item><description>Unit: Kbit/s.</description></item>
                                /// <item><description>Default value: 128.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>128</para>
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// <para>The number of sound channels. Default value: 2.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Channels")]
                                [Validation(Required=false)]
                                public string Channels { get; set; }

                                /// <summary>
                                /// <para>The audio codec. Valid values: AAC, MP3, VORBIS, and FLAC. Default value: AAC.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AAC</para>
                                /// </summary>
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }

                                /// <summary>
                                /// <para>The audio codec profile. If the Codec parameter is set to AAC, the valid values are aac_low, aac_he, aac_he_v2, aac_ld, and aac_eld.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>aac_low</para>
                                /// </summary>
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the audio stream is deleted.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }

                                /// <summary>
                                /// <para>The sampling rate.</para>
                                /// <list type="bullet">
                                /// <item><description>Default value: 44100.</description></item>
                                /// <item><description>Valid values: 22050, 32000, 44100, 48000, and 96000.</description></item>
                                /// <item><description>Unit: Hz.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>44100</para>
                                /// </summary>
                                [NameInMap("Samplerate")]
                                [Validation(Required=false)]
                                public string Samplerate { get; set; }

                                /// <summary>
                                /// <para>The volume configurations.</para>
                                /// </summary>
                                [NameInMap("Volume")]
                                [Validation(Required=false)]
                                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                    /// <summary>
                                    /// <para>The output volume.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>-6</para>
                                    /// </summary>
                                    [NameInMap("IntegratedLoudnessTarget")]
                                    [Validation(Required=false)]
                                    public string IntegratedLoudnessTarget { get; set; }

                                    /// <summary>
                                    /// <para>The volume range.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>8</para>
                                    /// </summary>
                                    [NameInMap("LoudnessRangeTarget")]
                                    [Validation(Required=false)]
                                    public string LoudnessRangeTarget { get; set; }

                                    /// <summary>
                                    /// <para>The volume adjustment method. Valid values:</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>auto</para>
                                    /// </summary>
                                    [NameInMap("Method")]
                                    [Validation(Required=false)]
                                    public string Method { get; set; }

                                    /// <summary>
                                    /// <para>The peak volume.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>-1</para>
                                    /// </summary>
                                    [NameInMap("TruePeak")]
                                    [Validation(Required=false)]
                                    public string TruePeak { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The encapsulation format settings.</para>
                            /// </summary>
                            [NameInMap("Container")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                                /// <summary>
                                /// <para>The container format.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>mp4</para>
                                /// </summary>
                                [NameInMap("Format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                            }

                            /// <summary>
                            /// <para>The encapsulation settings.</para>
                            /// </summary>
                            [NameInMap("MuxConfig")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                /// <summary>
                                /// <para>The segment settings.</para>
                                /// </summary>
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
                                    /// <summary>
                                    /// <para>The segment length.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>10</para>
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// <para>The forced segmentation point in time.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2,3</para>
                                    /// </summary>
                                    [NameInMap("ForceSegTime")]
                                    [Validation(Required=false)]
                                    public string ForceSegTime { get; set; }

                                }

                            }

                            [NameInMap("Tags")]
                            [Validation(Required=false)]
                            public Dictionary<string, string> Tags { get; set; }

                            /// <summary>
                            /// <para>The video settings.</para>
                            /// </summary>
                            [NameInMap("Video")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                                /// <summary>
                                /// <para>The maximum adaptive bitrate (ABR). This parameter takes effect only for Narrowband HD 1.0. Valid values: [10,50000]. Unit: Kbit/s.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>6000</para>
                                /// </summary>
                                [NameInMap("AbrMax")]
                                [Validation(Required=false)]
                                public string AbrMax { get; set; }

                                /// <summary>
                                /// <para>The average bitrate of the video.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [10,50000].</description></item>
                                /// <item><description>Unit: Kbit/s.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>3000</para>
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// <para>The buffer size.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [1000,128000].</description></item>
                                /// <item><description>Default value: 6000.</description></item>
                                /// <item><description>Unit: KB.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>6000</para>
                                /// </summary>
                                [NameInMap("Bufsize")]
                                [Validation(Required=false)]
                                public string Bufsize { get; set; }

                                /// <summary>
                                /// <para>The encoding format.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>H.264</para>
                                /// </summary>
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }

                                /// <summary>
                                /// <para>The constant rate factor.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [0,51].</description></item>
                                /// <item><description>Default value: 23 if the encoding format is H.264, or 26 if the encoding format is H.265.</description></item>
                                /// </list>
                                /// <para>If this parameter is set, the value of Bitrate becomes invalid.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>23</para>
                                /// </summary>
                                [NameInMap("Crf")]
                                [Validation(Required=false)]
                                public string Crf { get; set; }

                                /// <summary>
                                /// <para>The method of video cropping. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>border: automatically detects and removes black bars.</description></item>
                                /// <item><description>A value in the width:height:left:top format: crops the videos based on the custom settings. Example: 1280:800:0:140.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1280:800:0:140</para>
                                /// </summary>
                                [NameInMap("Crop")]
                                [Validation(Required=false)]
                                public string Crop { get; set; }

                                /// <summary>
                                /// <para>The frame rate.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: (0,60].</description></item>
                                /// <item><description>The value is 60 if the frame rate of the input video exceeds 60.</description></item>
                                /// <item><description>Default value: the frame rate of the input video.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>25</para>
                                /// </summary>
                                [NameInMap("Fps")]
                                [Validation(Required=false)]
                                public string Fps { get; set; }

                                /// <summary>
                                /// <para>The maximum number of frames between two keyframes.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [1,1080000].</description></item>
                                /// <item><description>Default value: 250.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>250</para>
                                /// </summary>
                                [NameInMap("Gop")]
                                [Validation(Required=false)]
                                public string Gop { get; set; }

                                /// <summary>
                                /// <para>The height of the output video.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [128,4096].</description></item>
                                /// <item><description>Unit: pixels.</description></item>
                                /// <item><description>Default value: the height of the input video.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1080</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the auto-rotate screen feature is enabled.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("LongShortMode")]
                                [Validation(Required=false)]
                                public string LongShortMode { get; set; }

                                /// <summary>
                                /// <para>The maximum bitrate of the output video. Valid values: [10,50000]. Unit: Kbit/s.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>9000</para>
                                /// </summary>
                                [NameInMap("Maxrate")]
                                [Validation(Required=false)]
                                public string Maxrate { get; set; }

                                /// <summary>
                                /// <para>The black bars added to the video.</para>
                                /// <list type="bullet">
                                /// <item><description>Format: width:height:left:top.</description></item>
                                /// <item><description>Example: 1280:800:0:140.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1280:800:0:140</para>
                                /// </summary>
                                [NameInMap("Pad")]
                                [Validation(Required=false)]
                                public string Pad { get; set; }

                                /// <summary>
                                /// <para>The pixel format of the video. Valid values: standard pixel formats such as yuv420p and yuvj420p.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>yuv420p</para>
                                /// </summary>
                                [NameInMap("PixFmt")]
                                [Validation(Required=false)]
                                public string PixFmt { get; set; }

                                /// <summary>
                                /// <para>The preset video algorithm. This parameter takes effect only if the encoding format is H.264. Valid values: veryfast, fast, medium, slow, and slower. Default value: medium.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>medium</para>
                                /// </summary>
                                [NameInMap("Preset")]
                                [Validation(Required=false)]
                                public string Preset { get; set; }

                                /// <summary>
                                /// <para>The encoding profile. Valid values: baseline, main, and high.</para>
                                /// <list type="bullet">
                                /// <item><description>baseline: applicable to mobile devices.</description></item>
                                /// <item><description>main: applicable to standard-definition devices.</description></item>
                                /// <item><description>high: applicable to high-definition devices.</description></item>
                                /// </list>
                                /// <para>Default value: high.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Main</para>
                                /// </summary>
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the video was removed.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }

                                /// <summary>
                                /// <para>The scan mode. Valid values: interlaced and progressive.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>progressive</para>
                                /// </summary>
                                [NameInMap("ScanMode")]
                                [Validation(Required=false)]
                                public string ScanMode { get; set; }

                                /// <summary>
                                /// <para>The width of the output video.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [128,4096].</description></item>
                                /// <item><description>Unit: pixels.</description></item>
                                /// <item><description>Default value: the width of the input video.</description></item>
                                /// </list>
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
                        /// <para>The template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The main job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8b2198504dd340b7b3c9842a74fc9baa</para>
            /// </summary>
            [NameInMap("ParentJobId")]
            [Validation(Required=false)]
            public string ParentJobId { get; set; }

            /// <summary>
            /// <para>The completion percentage of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <para>The ID of the request that submitted the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The scheduling configuration of the job.</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public ListTranscodeJobsResponseBodyJobsScheduleConfig ScheduleConfig { get; set; }
            public class ListTranscodeJobsResponseBodyJobsScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the MPS queue to which the job was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The priority of the job. Valid values: 1 to 10. The greater the value, the higher the priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The state of the job.</para>
            /// <list type="bullet">
            /// <item><description>Success: At least one of the subjobs is successful.</description></item>
            /// <item><description>Fail: All subjobs failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The source of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>API</description></item>
            /// <item><description>WorkFlow</description></item>
            /// <item><description>Console</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <para>The user data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-data</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. The token of the next page is returned after you call this operation for the first time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019daf5780f74831b0e1a767c9f1c178</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
