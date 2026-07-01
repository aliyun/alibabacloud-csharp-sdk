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
            /// <para>The time when the job was created. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job was complete. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The input group of the job. A single input indicates a transcoding job. Multiple inputs indicate a composition job.</para>
            /// </summary>
            [NameInMap("InputGroup")]
            [Validation(Required=false)]
            public List<ListTranscodeJobsResponseBodyJobsInputGroup> InputGroup { get; set; }
            public class ListTranscodeJobsResponseBodyJobsInputGroup : TeaModel {
                /// <summary>
                /// <para>The URL of the media stream. This parameter is required only when you transcode a media stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("InputUrl")]
                [Validation(Required=false)]
                public string InputUrl { get; set; }

                /// <summary>
                /// <para>The media information. The value of this parameter varies based on the value of Type.</para>
                /// <list type="bullet">
                /// <item><description><para>If Type is set to <c>OSS</c>, the value of this parameter must be an OSS URL. Both the <c>oss://</c> and <c>http(s)://</c> protocols are supported.</para>
                /// </description></item>
                /// <item><description><para>If Type is set to <c>Media</c>, the value of this parameter must be a media ID.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The type of the media asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>OSS</c>: an OSS file.</para>
                /// </description></item>
                /// <item><description><para><c>Media</c>: a media asset ID.</para>
                /// </description></item>
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
            /// <para>The number of sub-jobs.</para>
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
                /// <para>The output media configuration.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public ListTranscodeJobsResponseBodyJobsOutputGroupOutput Output { get; set; }
                public class ListTranscodeJobsResponseBodyJobsOutputGroupOutput : TeaModel {
                    /// <summary>
                    /// <para>The media information. The value of this parameter varies based on the value of Type.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If Type is set to <c>OSS</c>, the value of this parameter must be an OSS URL. Both the <c>oss://</c> and <c>http(s)://</c> protocols are supported.</para>
                    /// </description></item>
                    /// <item><description><para>If Type is set to <c>Media</c>, the value of this parameter must be a media ID.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// <para>The URL of the output stream. This parameter is required only when you transcode a media stream.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/{MediaId}/{JobId}.mp4</para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                    /// <summary>
                    /// <para>The type of the media asset. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>OSS</c>: an OSS file.</para>
                    /// </description></item>
                    /// <item><description><para><c>Media</c>: a media asset ID.</para>
                    /// </description></item>
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
                    /// <para>The configurations for combining multiple inputs.</para>
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
                        /// <para>0 or exclude</para>
                        /// </summary>
                        [NameInMap("AudioIndex")]
                        [Validation(Required=false)]
                        public string AudioIndex { get; set; }

                        /// <summary>
                        /// <para>The duration of the input stream. The default is the duration of the video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20.0</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public double? Duration { get; set; }

                        /// <summary>
                        /// <para>The start time of the input stream. The default value is 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public double? Start { get; set; }

                        /// <summary>
                        /// <para>The index of the video stream.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0 or exclude</para>
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
                        /// <para>The key ciphertext for standard encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MTYi00NDU0LTg5O****</para>
                        /// </summary>
                        [NameInMap("CipherText")]
                        [Validation(Required=false)]
                        public string CipherText { get; set; }

                        /// <summary>
                        /// <para>The URL of the decryption service for standard encryption.</para>
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
                    /// <para>The image watermark configurations.</para>
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The override parameter. If you specify this parameter, the corresponding parameter in the template is overwritten.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The horizontal offset of the watermark.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            /// <summary>
                            /// <para>The vertical offset of the watermark.</para>
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
                                /// <para>The media information. The value of this parameter varies based on the value of Type.</para>
                                /// <list type="bullet">
                                /// <item><description><para>If Type is set to <c>OSS</c>, the value of this parameter must be an OSS URL. Both the <c>oss://</c> and <c>http(s)://</c> protocols are supported.</para>
                                /// </description></item>
                                /// <item><description><para>If Type is set to <c>Media</c>, the value of this parameter must be a media ID.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>oss://bucket/path/to/video.mp4</para>
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// <para>The type of the media asset. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><para><c>OSS</c>: an OSS file.</para>
                                /// </description></item>
                                /// <item><description><para><c>Media</c>: a media asset ID.</para>
                                /// </description></item>
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
                            /// <para>The height of the watermark.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>32</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The reference position. Valid values: <c>TopLeft</c>, <c>TopRight</c>, <c>BottomLeft</c>, and <c>BottomRight</c>. Default value: <c>TopLeft</c>.</para>
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
                                /// <para>The display duration in seconds. You can also set the value to <c>ToEND</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ToEND</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The start time.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00:00:05</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }

                            /// <summary>
                            /// <para>The width of the watermark.</para>
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
                        /// <para>9547c6ad97cb4f2aaa29683ebd18****</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to inherit tags from the input stream. This parameter applies only when the input is a Media Asset. Default Value: false</para>
                    /// </summary>
                    [NameInMap("IsInheritTags")]
                    [Validation(Required=false)]
                    public bool? IsInheritTags { get; set; }

                    /// <summary>
                    /// <para>The subtitle burn-in settings.</para>
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// <para>The overwrite parameters. If specified, these parameters overwrite the corresponding parameters in the template.</para>
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
                                /// <para>The media value:</para>
                                /// <list type="bullet">
                                /// <item><description><para>If type is OSS, the value is a URL. Both OSS and HTTP protocols are supported.</para>
                                /// </description></item>
                                /// <item><description><para>If type is Media, the value is the Media Asset ID.</para>
                                /// </description></item>
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
                                /// <item><description><para>OSS: an Object Storage Service (OSS) file.</para>
                                /// </description></item>
                                /// <item><description><para>Media: the ID of the Media Asset.</para>
                                /// </description></item>
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
                        /// <para>9547c6ad97cb4f2aaa29683ebd18****</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    /// <summary>
                    /// <para>The text watermark configurations.</para>
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The override parameter. If you specify this parameter, the corresponding parameter in the template is overwritten.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether to adjust the font size based on the output video size.</para>
                            /// <list type="bullet">
                            /// <item><description><para><c>true</c>: The font size is automatically adjusted based on the output video size.</para>
                            /// </description></item>
                            /// <item><description><para><c>false</c>: The font size remains fixed and is not affected by the output video size.</para>
                            /// </description></item>
                            /// </list>
                            /// <para>Default value: false</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }

                            /// <summary>
                            /// <para>The color of the border.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }

                            /// <summary>
                            /// <para>The width of the border.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("BorderWidth")]
                            [Validation(Required=false)]
                            public int? BorderWidth { get; set; }

                            /// <summary>
                            /// <para>The watermark text, which must be UTF-8 encoded. The text does not need to be Base64 encoded.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Test watermark</para>
                            /// </summary>
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The transparency.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.0</para>
                            /// </summary>
                            [NameInMap("FontAlpha")]
                            [Validation(Required=false)]
                            public string FontAlpha { get; set; }

                            /// <summary>
                            /// <para>The color.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("FontColor")]
                            [Validation(Required=false)]
                            public string FontColor { get; set; }

                            /// <summary>
                            /// <para>The font.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SimSun</para>
                            /// </summary>
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }

                            /// <summary>
                            /// <para>The font size.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }

                            /// <summary>
                            /// <para>The distance from the left edge of the video.</para>
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
                        /// <para>9547c6ad97cb4f2aaa29683ebd18****</para>
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
                        /// <para>The override parameter. If you specify this parameter, the corresponding parameter in the template is overwritten.</para>
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
                                /// <item><description><para>Valid values: 8 to 1000.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbit/s.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 128.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>128</para>
                                /// </summary>
                                [NameInMap("Bitrate")]
                                [Validation(Required=false)]
                                public string Bitrate { get; set; }

                                /// <summary>
                                /// <para>The number of audio channels. Default value: 2.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Channels")]
                                [Validation(Required=false)]
                                public string Channels { get; set; }

                                /// <summary>
                                /// <para>The audio codec. Valid values: <c>AAC</c>, <c>MP3</c>, <c>VORBIS</c>, and <c>FLAC</c>. Default value: <c>AAC</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AAC</para>
                                /// </summary>
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }

                                /// <summary>
                                /// <para>The audio encoding preset. This parameter is supported only when the audio codec is AAC. Valid values: <c>aac_low</c>, <c>aac_he</c>, <c>aac_he_v2</c>, <c>aac_ld</c>, and <c>aac_eld</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>aac_low</para>
                                /// </summary>
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to delete the audio stream. Valid values: <c>true</c> and <c>false</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }

                                /// <summary>
                                /// <para>The sample rate.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: 22050, 32000, 44100, 48000, and 96000.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 44100.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Hz.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>44100</para>
                                /// </summary>
                                [NameInMap("Samplerate")]
                                [Validation(Required=false)]
                                public string Samplerate { get; set; }

                                /// <summary>
                                /// <para>The volume control settings.</para>
                                /// </summary>
                                [NameInMap("Volume")]
                                [Validation(Required=false)]
                                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                    /// <summary>
                                    /// <para>The target integrated loudness.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>-6</para>
                                    /// </summary>
                                    [NameInMap("IntegratedLoudnessTarget")]
                                    [Validation(Required=false)]
                                    public string IntegratedLoudnessTarget { get; set; }

                                    /// <summary>
                                    /// <para>The target loudness range.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>8</para>
                                    /// </summary>
                                    [NameInMap("LoudnessRangeTarget")]
                                    [Validation(Required=false)]
                                    public string LoudnessRangeTarget { get; set; }

                                    /// <summary>
                                    /// <para>The volume adjustment method.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>auto</para>
                                    /// </summary>
                                    [NameInMap("Method")]
                                    [Validation(Required=false)]
                                    public string Method { get; set; }

                                    /// <summary>
                                    /// <para>The true peak level.</para>
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
                            /// <para>The container format settings.</para>
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
                            /// <para>The muxing settings.</para>
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
                                    /// <para>The duration of each segment.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>10</para>
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// <para>The time points at which to enforce segmentation.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2,3</para>
                                    /// </summary>
                                    [NameInMap("ForceSegTime")]
                                    [Validation(Required=false)]
                                    public string ForceSegTime { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The custom tags.</para>
                            /// </summary>
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
                                /// <para>The maximum bitrate for adaptive bitrate (ABR) streaming. This parameter is valid only for videos with a narrow height and a wide width. Valid values: 10 to 50000. Unit: Kbit/s.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>6000</para>
                                /// </summary>
                                [NameInMap("AbrMax")]
                                [Validation(Required=false)]
                                public string AbrMax { get; set; }

                                /// <summary>
                                /// <para>The average video bitrate.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: 10 to 50000.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbit/s.</para>
                                /// </description></item>
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
                                /// <item><description><para>Valid values: 1000 to 128000.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 6000.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbit.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>6000</para>
                                /// </summary>
                                [NameInMap("Bufsize")]
                                [Validation(Required=false)]
                                public string Bufsize { get; set; }

                                /// <summary>
                                /// <para>The video codec.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>H.264</para>
                                /// </summary>
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }

                                /// <summary>
                                /// <para>The quality-to-bitrate control factor.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: 0 to 51.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: If the codec is H.264, the default value is 23. If the codec is H.265, the default value is 26.</para>
                                /// </description></item>
                                /// </list>
                                /// <para>If you specify Crf, the value of Bitrate is ignored.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>23</para>
                                /// </summary>
                                [NameInMap("Crf")]
                                [Validation(Required=false)]
                                public string Crf { get; set; }

                                /// <summary>
                                /// <para>The cropping settings. Two modes are supported.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Automatic: Set the value to <c>border</c> to automatically detect and crop black borders.</para>
                                /// </description></item>
                                /// <item><description><para>Manual: Specify the crop area in the <c>width:height:left:top</c> format. Example: <c>1280:800:0:140</c>.</para>
                                /// </description></item>
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
                                /// <item><description><para>Valid values: 0 to 60.</para>
                                /// </description></item>
                                /// <item><description><para>If the frame rate of the input file is greater than 60, the value is 60.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: the frame rate of the input file.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>25</para>
                                /// </summary>
                                [NameInMap("Fps")]
                                [Validation(Required=false)]
                                public string Fps { get; set; }

                                /// <summary>
                                /// <para>The maximum number of frames in a Group of Pictures (GOP).</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: 1 to 1080000.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 250.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>250</para>
                                /// </summary>
                                [NameInMap("Gop")]
                                [Validation(Required=false)]
                                public string Gop { get; set; }

                                /// <summary>
                                /// <para>The height.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: 128 to 4096.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: px.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: the height of the source video.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1080</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public string Height { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to enable adaptive resolution by long and short sides.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("LongShortMode")]
                                [Validation(Required=false)]
                                public string LongShortMode { get; set; }

                                /// <summary>
                                /// <para>The maximum video bitrate. Valid values: 10 to 50000. Unit: Kbit/s.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>9000</para>
                                /// </summary>
                                [NameInMap("Maxrate")]
                                [Validation(Required=false)]
                                public string Maxrate { get; set; }

                                /// <summary>
                                /// <para>The settings for adding black bars.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Format: <c>width:height:left:top</c>.</para>
                                /// </description></item>
                                /// <item><description><para>Example: <c>1280:800:0:140</c>.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1280:800:0:140</para>
                                /// </summary>
                                [NameInMap("Pad")]
                                [Validation(Required=false)]
                                public string Pad { get; set; }

                                /// <summary>
                                /// <para>The pixel format. Valid values include <c>yuv420p</c> and <c>yuvj420p</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>yuv420p</para>
                                /// </summary>
                                [NameInMap("PixFmt")]
                                [Validation(Required=false)]
                                public string PixFmt { get; set; }

                                /// <summary>
                                /// <para>The preset of the video encoder. This parameter is supported only when the video codec is H.264. Valid values: <c>veryfast</c>, <c>fast</c>, <c>medium</c>, <c>slow</c>, and <c>slower</c>. Default value: <c>medium</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>medium</para>
                                /// </summary>
                                [NameInMap("Preset")]
                                [Validation(Required=false)]
                                public string Preset { get; set; }

                                /// <summary>
                                /// <para>The encoding profile. Valid values include baseline, main, and high.</para>
                                /// <list type="bullet">
                                /// <item><description><para><c>baseline</c>: suitable for mobile devices.</para>
                                /// </description></item>
                                /// <item><description><para><c>main</c>: suitable for standard-definition devices.</para>
                                /// </description></item>
                                /// <item><description><para><c>high</c>: suitable for high-definition devices.</para>
                                /// </description></item>
                                /// </list>
                                /// <para>Default value: <c>high</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Main</para>
                                /// </summary>
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to delete the video. Valid values: <c>true</c> and <c>false</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("Remove")]
                                [Validation(Required=false)]
                                public string Remove { get; set; }

                                /// <summary>
                                /// <para>The scan mode. Valid values: <c>interlaced</c> and <c>progressive</c>.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>progressive</para>
                                /// </summary>
                                [NameInMap("ScanMode")]
                                [Validation(Required=false)]
                                public string ScanMode { get; set; }

                                /// <summary>
                                /// <para>The width.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: 128 to 4096.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: px.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: the width of the source video.</para>
                                /// </description></item>
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
                        /// <para>9547c6ad97cb4f2aaa29683ebd18****</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The parent job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8b2198504dd340b7b3c9842a74fc****</para>
            /// </summary>
            [NameInMap("ParentJobId")]
            [Validation(Required=false)]
            public string ParentJobId { get; set; }

            /// <summary>
            /// <para>The progress of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <para>The request ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The schedule configuration of the job.</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public ListTranscodeJobsResponseBodyJobsScheduleConfig ScheduleConfig { get; set; }
            public class ListTranscodeJobsResponseBodyJobsScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The pipeline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e37ebee5d98b4781897f6086e89f****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The priority of the job. A larger value indicates a higher priority. The value can be an integer from 1 to 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Success</c>: The job is successful if at least one sub-job is successful.</para>
            /// </description></item>
            /// <item><description><para><c>Fail</c>: The job fails if all sub-jobs fail.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted. The time is in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
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
            /// <item><description><para><c>API</c>: The job is submitted by calling an API operation.</para>
            /// </description></item>
            /// <item><description><para><c>Workflow</c>: The job is triggered by a workflow.</para>
            /// </description></item>
            /// <item><description><para><c>Console</c>: The job is submitted on the console.</para>
            /// </description></item>
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
        /// <para>The token for the next page of results. Leave this parameter empty for the first request. The token is returned after the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019daf5780f74831b0e1a767c9f1****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
