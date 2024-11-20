// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>TranscodeParentJobWithSubJobDTO</para>
        /// </summary>
        [NameInMap("TranscodeParentJob")]
        [Validation(Required=false)]
        public SubmitTranscodeJobResponseBodyTranscodeParentJob TranscodeParentJob { get; set; }
        public class SubmitTranscodeJobResponseBodyTranscodeParentJob : TeaModel {
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
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobInputGroup> InputGroup { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobInputGroup : TeaModel {
                /// <summary>
                /// <para>The media object.</para>
                /// <list type="bullet">
                /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroup> OutputGroup { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroup : TeaModel {
                /// <summary>
                /// <para>The output file configuration.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput Output { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput : TeaModel {
                    /// <summary>
                    /// <para>The media object.</para>
                    /// <list type="bullet">
                    /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                    /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
                /// <para>The job processing configuration.</para>
                /// </summary>
                [NameInMap("ProcessConfig")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig ProcessConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig : TeaModel {
                    /// <summary>
                    /// <para>The multi-input stream merge configuration.</para>
                    /// </summary>
                    [NameInMap("CombineConfigs")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigCombineConfigs> CombineConfigs { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigCombineConfigs : TeaModel {
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
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigEncryption Encryption { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigEncryption : TeaModel {
                        /// <summary>
                        /// <para>The ciphertext of HLS encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MTYi00NDU0LTg5O****</para>
                        /// </summary>
                        [NameInMap("CipherText")]
                        [Validation(Required=false)]
                        public string CipherText { get; set; }

                        /// <summary>
                        /// <para>The address of the decryption service for HLS encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://sample.com/path?CipherText=MTYi00NDU0LTg5O">https://sample.com/path?CipherText=MTYi00NDU0LTg5O</a>****</para>
                        /// </summary>
                        [NameInMap("DecryptKeyUri")]
                        [Validation(Required=false)]
                        public string DecryptKeyUri { get; set; }

                        /// <summary>
                        /// <para>Specifies the encryption type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrivateEncryption</para>
                        /// </summary>
                        [NameInMap("EncryptType")]
                        [Validation(Required=false)]
                        public string EncryptType { get; set; }

                        /// <summary>
                        /// <para>The type of the key service. Valid values: KMS and Base64.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KMS</para>
                        /// </summary>
                        [NameInMap("KeyServiceType")]
                        [Validation(Required=false)]
                        public string KeyServiceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The watermark configuration of an image.</para>
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The horizontal offset of the watermark relative to the output video. Default value: 0.</para>
                            /// <para>The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the horizontal offset.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the horizontal offset to the width of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            /// <summary>
                            /// <para>The vertical offset of the watermark relative to the output video. Default value: 0.</para>
                            /// <para>The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the horizontal offset.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the vertical offset to the height of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// <para>The media object.</para>
                                /// <list type="bullet">
                                /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                                /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
                            /// <para>The height of the watermark image in the output video. The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the watermark height.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the watermark height to the height of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>32</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The position of the watermark.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: TopRight, TopLeft, BottomRight, and BottomLeft.</description></item>
                            /// <item><description>Default value: TopRight.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TopLeft</para>
                            /// </summary>
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            /// <summary>
                            /// <para>The time settings of the dynamic watermark.</para>
                            /// </summary>
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                /// <summary>
                                /// <para>The time range in which the watermark is displayed.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: integers and ToEND.</description></item>
                                /// <item><description>Default value: ToEND.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ToEND</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The beginning of the time range in which the watermark is displayed.</para>
                                /// <list type="bullet">
                                /// <item><description>Unit: seconds.</description></item>
                                /// <item><description>Value values: integers.</description></item>
                                /// <item><description>Default value: 0.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00:00:05</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }

                            /// <summary>
                            /// <para>The width of the watermark in the output video. The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the watermark width.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the watermark width to the width of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
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
                    /// <para>The subtitle configuration.</para>
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// <para>The media object. If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported. If Type is set to Media, set this parameter to the ID of a media asset.</para>
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
                    /// <para>The configurations of the text watermark.</para>
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether to the font size based on the output video dimensions.</para>
                            /// <list type="bullet">
                            /// <item><description>true: false</description></item>
                            /// <item><description>default: false</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }

                            /// <summary>
                            /// <para>The outline color of the text watermark. Default value: black. For more information, see BorderColor.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }

                            /// <summary>
                            /// <para>The outline width of the text watermark.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 0.</description></item>
                            /// <item><description>Valid values: (0,4096].</description></item>
                            /// </list>
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
                            /// <para>The transparency of the text.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1].</description></item>
                            /// <item><description>Default value: 1.</description></item>
                            /// </list>
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
                            /// <para>The font of the text. Default value: SimSun.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SimSun</para>
                            /// </summary>
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }

                            /// <summary>
                            /// <para>The size of the text.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 16.</description></item>
                            /// <item><description>Valid values: (4,120).</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }

                            /// <summary>
                            /// <para>The left margin of the text watermark.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 0.</description></item>
                            /// <item><description>Valid values: [0,4096].</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public string Left { get; set; }

                            /// <summary>
                            /// <para>The top margin of the text.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 0.</description></item>
                            /// <item><description>Valid values: [0,4096].</description></item>
                            /// </list>
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
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscode Transcode { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscode : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The audio settings.</para>
                            /// </summary>
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
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
                                /// <para>Specifies whether to delete the audio stream.</para>
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
                                /// <item><description>Valid values: 22050, 32000, 44100, 48000, and 96000. Default value: 44100.</description></item>
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
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                /// <summary>
                                /// <para>The segment settings.</para>
                                /// </summary>
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
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

                            /// <summary>
                            /// <para>The conditional transcoding configurations.</para>
                            /// </summary>
                            [NameInMap("TransConfig")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
                                /// <summary>
                                /// <para>The method that is used to adjust the resolution. This parameter takes effect only if both the Width and Height parameters are specified. You can use this parameter together with the LongShortMode parameter.</para>
                                /// <para>Valid values: rescale, crop, pad, and none.</para>
                                /// <para>Default value: none.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>none</para>
                                /// </summary>
                                [NameInMap("AdjDarMethod")]
                                [Validation(Required=false)]
                                public string AdjDarMethod { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the audio bitrate. You can specify only one of the IsCheckAudioBitrate and IsCheckAudioBitrateFail parameters. The priority of the IsCheckAudioBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input audio is less than that of the output audio, the bitrate of the input audio is used for transcoding.</description></item>
                                /// <item><description>false: does not check the video resolution.</description></item>
                                /// </list>
                                /// <para>Default value:</para>
                                /// <list type="bullet">
                                /// <item><description>If this parameter is not specified and the codec of the output audio is different from that of the input audio, the default value is false.</description></item>
                                /// <item><description>If this parameter is not specified and the codec of the output audio is the same as that of the input audio, the default value is true.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckAudioBitrate")]
                                [Validation(Required=false)]
                                public string IsCheckAudioBitrate { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the audio bitrate. You can specify only one of the IsCheckAudioBitrate and IsCheckAudioBitrateFail parameters. The priority of the IsCheckAudioBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input audio is less than that of the output audio, the transcoding job fails.</description></item>
                                /// <item><description>false: does not check the video resolution.</description></item>
                                /// </list>
                                /// <para>Default value: false.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckAudioBitrateFail")]
                                [Validation(Required=false)]
                                public string IsCheckAudioBitrateFail { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video resolution. You can specify only one of the IsCheckReso and IsCheckResoFail parameters. The priority of the IsCheckResoFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the width or height of the input video is less than that of the output video, the resolution of the input video is used for transcoding.</description></item>
                                /// <item><description>false: does not check the video resolution.</description></item>
                                /// </list>
                                /// <para>Default value: false.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckReso")]
                                [Validation(Required=false)]
                                public string IsCheckReso { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video resolution. You can specify only one of the IsCheckReso and IsCheckResoFail parameters. The priority of the IsCheckResoFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the width or height of the input video is less than that of the output video, the transcoding job fails.</description></item>
                                /// <item><description>false: does not check the video resolution.</description></item>
                                /// </list>
                                /// <para>Default value: false.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckResoFail")]
                                [Validation(Required=false)]
                                public string IsCheckResoFail { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video bitrate. You can specify only one of the IsCheckVideoBitrate and IsCheckVideoBitrateFail parameters. The priority of the IsCheckVideoBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input video is less than that of the output video, the bitrate of the input video is used for transcoding.</description></item>
                                /// <item><description>false: does not check the video resolution.</description></item>
                                /// </list>
                                /// <para>Default value: false.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckVideoBitrate")]
                                [Validation(Required=false)]
                                public string IsCheckVideoBitrate { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video bitrate. You can specify only one of the IsCheckVideoBitrate and IsCheckVideoBitrateFail parameters. The priority of the IsCheckVideoBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input video is less than that of the output video, the transcoding job fails.</description></item>
                                /// <item><description>false: does not check the video resolution.</description></item>
                                /// </list>
                                /// <para>Default value: false.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckVideoBitrateFail")]
                                [Validation(Required=false)]
                                public string IsCheckVideoBitrateFail { get; set; }

                                /// <summary>
                                /// <para>The video transcoding mode. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>onepass: You can set this parameter to onepass if the Bitrate parameter is set to ABR. The encoding speed of this mode is faster than that of the twopass mode.</description></item>
                                /// <item><description>twopass: You can set this parameter to twopass if the Bitrate parameter is set to VBR. The encoding speed of this mode is slower than that of the onepass mode.</description></item>
                                /// <item><description>CBR: the constant bitrate mode.</description></item>
                                /// </list>
                                /// <para>Default value: onepass.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>onepass</para>
                                /// </summary>
                                [NameInMap("TransMode")]
                                [Validation(Required=false)]
                                public string TransMode { get; set; }

                            }

                            /// <summary>
                            /// <para>The video settings.</para>
                            /// </summary>
                            [NameInMap("Video")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                                /// <summary>
                                /// <para>The maximum ABR. This parameter takes effect only for Narrowband HD 1.0.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [10,50000].</description></item>
                                /// <item><description>Unit: Kbit/s.</description></item>
                                /// </list>
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
                                /// <item><description>Default value: 23 if the encoding format is H.264, or Default value when the Codec parameter is set to H.265: 26.</description></item>
                                /// </list>
                                /// <para>If this parameter is specified, the value of Bitrate becomes invalid.</para>
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
                                /// <para>Specifies whether to enable the auto-rotate screen feature.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("LongShortMode")]
                                [Validation(Required=false)]
                                public string LongShortMode { get; set; }

                                /// <summary>
                                /// <para>The maximum bitrate of the output video.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: [10,50000].</description></item>
                                /// <item><description>Unit: Kbit/s.</description></item>
                                /// </list>
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
                                /// <para>Specifies whether to remove the video.</para>
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
            public SubmitTranscodeJobResponseBodyTranscodeParentJobScheduleConfig ScheduleConfig { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobScheduleConfig : TeaModel {
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
            /// <para>The state of the job. Success: At least one of the subjobs is successful. Fail: All subjobs failed.</para>
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
            /// <para>The list of subjobs.</para>
            /// </summary>
            [NameInMap("TranscodeJobList")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList> TranscodeJobList { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList : TeaModel {
                /// <summary>
                /// <para>The time when the job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T08:49:41Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the job was complete.</para>
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
                public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup> InputGroup { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup : TeaModel {
                    /// <summary>
                    /// <para>The URL of the input stream:</para>
                    /// <list type="bullet">
                    /// <item><description>This parameter takes effect only when Type is set to Media. You can select a specific file within the media asset as an input.</description></item>
                    /// <item><description>The system checks whether the input URL exists within the media asset.</description></item>
                    /// </list>
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
                    /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                    /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
                /// <para>The subjob ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7d6a7e0d4db2457a8d45ff5d43e1bf0a</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The index number of the subjob in the entire job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("JobIndex")]
                [Validation(Required=false)]
                public int? JobIndex { get; set; }

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
                /// <para>The media information about the video generated by the job.</para>
                /// </summary>
                [NameInMap("OutFileMeta")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta OutFileMeta { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta : TeaModel {
                    /// <summary>
                    /// <para>The information about the audio stream.</para>
                    /// </summary>
                    [NameInMap("AudioStreamInfoList")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaAudioStreamInfoList> AudioStreamInfoList { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaAudioStreamInfoList : TeaModel {
                        /// <summary>
                        /// <para>The bitrate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.f</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The sound channel layout.</para>
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
                        /// <para>The name of the encoding format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AAC (Advanced Audio Coding)</para>
                        /// </summary>
                        [NameInMap("CodecLongName")]
                        [Validation(Required=false)]
                        public string CodecLongName { get; set; }

                        /// <summary>
                        /// <para>The encoding format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>aac</para>
                        /// </summary>
                        [NameInMap("CodecName")]
                        [Validation(Required=false)]
                        public string CodecName { get; set; }

                        /// <summary>
                        /// <para>The encoder tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0x000f</para>
                        /// </summary>
                        [NameInMap("CodecTag")]
                        [Validation(Required=false)]
                        public string CodecTag { get; set; }

                        /// <summary>
                        /// <para>The name of the encoder tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[15][0][0][0]</para>
                        /// </summary>
                        [NameInMap("CodecTagString")]
                        [Validation(Required=false)]
                        public string CodecTagString { get; set; }

                        /// <summary>
                        /// <para>The time base of the encoder.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1/44100</para>
                        /// </summary>
                        [NameInMap("CodecTimeBase")]
                        [Validation(Required=false)]
                        public string CodecTimeBase { get; set; }

                        /// <summary>
                        /// <para>The duration of the stream. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>403.039989</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>The sequence number of the stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        /// <summary>
                        /// <para>The language of the stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn</para>
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

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
                        /// <para>The sampling rate. Unit: Hz.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>44100</para>
                        /// </summary>
                        [NameInMap("SampleRate")]
                        [Validation(Required=false)]
                        public string SampleRate { get; set; }

                        /// <summary>
                        /// <para>The start time of the stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.473556</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time base.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1/90000</para>
                        /// </summary>
                        [NameInMap("Timebase")]
                        [Validation(Required=false)]
                        public string Timebase { get; set; }

                    }

                    /// <summary>
                    /// <para>The basic file information.</para>
                    /// </summary>
                    [NameInMap("FileBasicInfo")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaFileBasicInfo FileBasicInfo { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaFileBasicInfo : TeaModel {
                        /// <summary>
                        /// <para>The video bitrate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>888.563</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <para>The duration of the video. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>403.039999</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>The file name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>file.m3u8</para>
                        /// </summary>
                        [NameInMap("FileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        /// <summary>
                        /// <para>The file size. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>31737</para>
                        /// </summary>
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// <para>The state of the file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Normal</para>
                        /// </summary>
                        [NameInMap("FileStatus")]
                        [Validation(Required=false)]
                        public string FileStatus { get; set; }

                        /// <summary>
                        /// <para>The file type. Valid values: source_file and transcode_file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>source_file</para>
                        /// </summary>
                        [NameInMap("FileType")]
                        [Validation(Required=false)]
                        public string FileType { get; set; }

                        /// <summary>
                        /// <para>The URL of the file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8">http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8</a></para>
                        /// </summary>
                        [NameInMap("FileUrl")]
                        [Validation(Required=false)]
                        public string FileUrl { get; set; }

                        /// <summary>
                        /// <para>The name of the video format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hls,applehttp</para>
                        /// </summary>
                        [NameInMap("FormatName")]
                        [Validation(Required=false)]
                        public string FormatName { get; set; }

                        /// <summary>
                        /// <para>The height of the output video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>478</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The ID of the media asset.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>73e07de0f77171eca3fc7035d0b26402</para>
                        /// </summary>
                        [NameInMap("MediaId")]
                        [Validation(Required=false)]
                        public string MediaId { get; set; }

                        /// <summary>
                        /// <para>The region in which the file resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-shanghai</para>
                        /// </summary>
                        [NameInMap("Region")]
                        [Validation(Required=false)]
                        public string Region { get; set; }

                        /// <summary>
                        /// <para>The width of the output video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>848</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the video stream.</para>
                    /// </summary>
                    [NameInMap("VideoStreamInfoList")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaVideoStreamInfoList> VideoStreamInfoList { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaVideoStreamInfoList : TeaModel {
                        /// <summary>
                        /// <para>The average frame rate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>25.0</para>
                        /// </summary>
                        [NameInMap("Avg_fps")]
                        [Validation(Required=false)]
                        public string AvgFps { get; set; }

                        /// <summary>
                        /// <para>The bitrate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>888.563</para>
                        /// </summary>
                        [NameInMap("Bit_rate")]
                        [Validation(Required=false)]
                        public string BitRate { get; set; }

                        /// <summary>
                        /// <para>The name of the encoding format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                        /// </summary>
                        [NameInMap("Codec_long_name")]
                        [Validation(Required=false)]
                        public string CodecLongName { get; set; }

                        /// <summary>
                        /// <para>The encoding format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>h264</para>
                        /// </summary>
                        [NameInMap("Codec_name")]
                        [Validation(Required=false)]
                        public string CodecName { get; set; }

                        /// <summary>
                        /// <para>The tag of the encoding format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0x001b</para>
                        /// </summary>
                        [NameInMap("Codec_tag")]
                        [Validation(Required=false)]
                        public string CodecTag { get; set; }

                        /// <summary>
                        /// <para>The tag string of the encoding format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[27][0][0][0]</para>
                        /// </summary>
                        [NameInMap("Codec_tag_string")]
                        [Validation(Required=false)]
                        public string CodecTagString { get; set; }

                        /// <summary>
                        /// <para>The time base of the encoder.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1/50</para>
                        /// </summary>
                        [NameInMap("Codec_time_base")]
                        [Validation(Required=false)]
                        public string CodecTimeBase { get; set; }

                        /// <summary>
                        /// <para>The display aspect ratio.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16:9</para>
                        /// </summary>
                        [NameInMap("Dar")]
                        [Validation(Required=false)]
                        public string Dar { get; set; }

                        /// <summary>
                        /// <para>The duration of the stream. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>403.039989</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

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
                        /// <para>Indicates whether the video stream contains bidirectional frames (B-frames). Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: The stream contains no B-frames.</description></item>
                        /// <item><description>1: The stream contains one B-frame.</description></item>
                        /// <item><description>2: The stream contains multiple consecutive B-frames.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Has_b_frames")]
                        [Validation(Required=false)]
                        public string HasBFrames { get; set; }

                        /// <summary>
                        /// <para>The height of the output video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>478</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The sequence number of the stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        /// <summary>
                        /// <para>The language of the stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn</para>
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

                        /// <summary>
                        /// <para>The codec level.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>31</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>The total number of frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10040</para>
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
                        /// <para>The encoder profile.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>High</para>
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// <para>The rotation angle of the video image. Valid values: 0, 90, 180, and 270. Default value: 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Rotate")]
                        [Validation(Required=false)]
                        public string Rotate { get; set; }

                        /// <summary>
                        /// <para>The aspect ratio of the area from which the sampling points are collected.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>478:477</para>
                        /// </summary>
                        [NameInMap("Sar")]
                        [Validation(Required=false)]
                        public string Sar { get; set; }

                        /// <summary>
                        /// <para>The start time of the stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.473556</para>
                        /// </summary>
                        [NameInMap("Start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <para>The time base.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1/90000</para>
                        /// </summary>
                        [NameInMap("Time_base")]
                        [Validation(Required=false)]
                        public string TimeBase { get; set; }

                        /// <summary>
                        /// <para>The width of the output video.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>848</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }

                /// <summary>
                /// <para>The output file configuration.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput Output { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput : TeaModel {
                    /// <summary>
                    /// <para>The media object.</para>
                    /// <list type="bullet">
                    /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                    /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    /// <summary>
                    /// <para>The URL of the output stream.\
                    /// This parameter takes effect only when Type is set to Media. You can select a specific file within the media asset as an output.\
                    /// Supported placeholders:</para>
                    /// <list type="bullet">
                    /// <item><description>{MediaId}: the ID of the media asset.</description></item>
                    /// <item><description>{JobId}: the ID of the transcoding subjob.</description></item>
                    /// <item><description>{MediaBucket}: the bucket to which the media asset belongs.</description></item>
                    /// <item><description>{ExtName}: the file suffix, which uses the output format of the transcoding template.</description></item>
                    /// <item><description>{DestMd5}: the MD5 value of the transcoded output file.\
                    /// Notes:</description></item>
                    /// </list>
                    /// <ol>
                    /// <item><description>This parameter must contain the {MediaId} and {JobId} placeholders.</description></item>
                    /// <item><description>The output bucket is the same as the bucket to which the media asset belongs.</description></item>
                    /// </ol>
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
                /// <para>The main job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8b2198504dd340b7b3c9842a74fc9baa</para>
                /// </summary>
                [NameInMap("ParentJobId")]
                [Validation(Required=false)]
                public string ParentJobId { get; set; }

                /// <summary>
                /// <para>The transcoding configuration.</para>
                /// </summary>
                [NameInMap("ProcessConfig")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig ProcessConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig : TeaModel {
                    /// <summary>
                    /// <para>The multi-input stream merge configuration.</para>
                    /// </summary>
                    [NameInMap("CombineConfigs")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigCombineConfigs> CombineConfigs { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigCombineConfigs : TeaModel {
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
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigEncryption Encryption { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigEncryption : TeaModel {
                        /// <summary>
                        /// <para>The ciphertext of HLS encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MTYi00NDU0LTg5O****</para>
                        /// </summary>
                        [NameInMap("CipherText")]
                        [Validation(Required=false)]
                        public string CipherText { get; set; }

                        /// <summary>
                        /// <para>The address of the decryption service for HLS encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://sample.com/path?CipherText=MTYi00NDU0LTg5O">https://sample.com/path?CipherText=MTYi00NDU0LTg5O</a>****</para>
                        /// </summary>
                        [NameInMap("DecryptKeyUri")]
                        [Validation(Required=false)]
                        public string DecryptKeyUri { get; set; }

                        /// <summary>
                        /// <para>Specifies the encryption type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrivateEncryption</para>
                        /// </summary>
                        [NameInMap("EncryptType")]
                        [Validation(Required=false)]
                        public string EncryptType { get; set; }

                        /// <summary>
                        /// <para>The type of the key service. Valid values: KMS and Base64.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KMS</para>
                        /// </summary>
                        [NameInMap("KeyServiceType")]
                        [Validation(Required=false)]
                        public string KeyServiceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The watermark configuration of an image.</para>
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The horizontal offset of the watermark relative to the output video. Default value: 0.</para>
                            /// <para>The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the horizontal offset.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the horizontal offset to the width of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            /// <summary>
                            /// <para>The vertical offset of the watermark relative to the output video. Default value: 0.</para>
                            /// <para>The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the horizontal offset.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the vertical offset to the height of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// <para>The media object.</para>
                                /// <list type="bullet">
                                /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                                /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
                            /// <para>The height of the watermark image in the output video. The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the watermark height.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the watermark height to the height of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>32</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <para>The position of the watermark.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: TopRight, TopLeft, BottomRight, and BottomLeft.</description></item>
                            /// <item><description>Default value: TopRight.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TopLeft</para>
                            /// </summary>
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            /// <summary>
                            /// <para>The time settings of the dynamic watermark.</para>
                            /// </summary>
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                /// <summary>
                                /// <para>The time range in which the watermark is displayed.</para>
                                /// <list type="bullet">
                                /// <item><description>Valid values: integers and ToEND.</description></item>
                                /// <item><description>Default value: ToEND.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ToEND</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The beginning of the time range in which the watermark is displayed.</para>
                                /// <list type="bullet">
                                /// <item><description>Unit: seconds.</description></item>
                                /// <item><description>Value values: integers.</description></item>
                                /// <item><description>Default value: 0.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>00:00:05</para>
                                /// </summary>
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }

                            }

                            /// <summary>
                            /// <para>The width of the watermark in the output video. The following value types are supported:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: the pixel value of the watermark width.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: [8,4096].</description></item>
                            /// <item><description>Unit: pixels.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: the ratio of the watermark width to the width of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1).</description></item>
                            /// <item><description>The decimal number can be accurate to four decimal places, such as 0.9999. Excessive digits are automatically discarded.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
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
                    /// <para>The subtitle configuration.</para>
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles> Subtitles { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams : TeaModel {
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// <para>The media object.</para>
                                /// <list type="bullet">
                                /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                                /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
                    /// <para>The configurations of the text watermark.</para>
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether to the font size based on the output video dimensions. true / false, default: false</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }

                            /// <summary>
                            /// <para>The outline color of the text watermark. Default value: black. For more information, see BorderColor.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }

                            /// <summary>
                            /// <para>The outline width of the text watermark.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 0.</description></item>
                            /// <item><description>Valid values: (0,4096].</description></item>
                            /// </list>
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
                            /// <para>The transparency of the text.</para>
                            /// <list type="bullet">
                            /// <item><description>Valid values: (0,1].</description></item>
                            /// <item><description>Default value: 1.</description></item>
                            /// </list>
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
                            /// <para>The font of the text. Default value: SimSun.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SimSun</para>
                            /// </summary>
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }

                            /// <summary>
                            /// <para>The size of the text.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 16.</description></item>
                            /// <item><description>Valid values: (4,120).</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }

                            /// <summary>
                            /// <para>The left margin of the text watermark.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 0.</description></item>
                            /// <item><description>Valid values: [0,4096].</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public string Left { get; set; }

                            /// <summary>
                            /// <para>The top margin of the text.</para>
                            /// <list type="bullet">
                            /// <item><description>Default value: 0.</description></item>
                            /// <item><description>Valid values: [0,4096].</description></item>
                            /// </list>
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
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscode Transcode { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscode : TeaModel {
                        /// <summary>
                        /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The audio settings.</para>
                            /// </summary>
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
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
                                /// <para>Specifies whether to delete the audio stream.</para>
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
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
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
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                /// <summary>
                                /// <para>The segment settings.</para>
                                /// </summary>
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
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

                            /// <summary>
                            /// <para>The conditional transcoding configurations.</para>
                            /// </summary>
                            [NameInMap("TransConfig")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
                                /// <summary>
                                /// <para>The method that is used to adjust the resolution. This parameter takes effect only if both the Width and Height parameters are specified. You can use this parameter together with the LongShortMode parameter.</para>
                                /// <para>Valid values: rescale, crop, pad, and none.</para>
                                /// <para>Default value: none.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>none</para>
                                /// </summary>
                                [NameInMap("AdjDarMethod")]
                                [Validation(Required=false)]
                                public string AdjDarMethod { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the audio bitrate. You can specify only one of the IsCheckAudioBitrate and IsCheckAudioBitrateFail parameters. The priority of the IsCheckAudioBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input audio is less than that of the output audio, the bitrate of the input audio is used for transcoding.</description></item>
                                /// <item><description>false: does not check the video resolution.</description></item>
                                /// </list>
                                /// <para>Default values:</para>
                                /// <list type="bullet">
                                /// <item><description>If this parameter is not specified and the codec of the output audio is different from that of the input audio, the default value is false.</description></item>
                                /// <item><description>If this parameter is not specified and the codec of the output audio is the same as that of the input audio, the default value is true.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckAudioBitrate")]
                                [Validation(Required=false)]
                                public string IsCheckAudioBitrate { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the audio bitrate. You can specify only one of the IsCheckAudioBitrate and IsCheckAudioBitrateFail parameters. The priority of the IsCheckAudioBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input audio is less than that of the output audio, the transcoding job fails.</description></item>
                                /// <item><description>false: does not check the video resolution. This is the default value.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckAudioBitrateFail")]
                                [Validation(Required=false)]
                                public string IsCheckAudioBitrateFail { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video resolution. You can specify only one of the IsCheckReso and IsCheckResoFail parameters. The priority of the IsCheckResoFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the width or height of the input video is less than that of the output video, the resolution of the input video is used for transcoding.</description></item>
                                /// <item><description>false: does not check the video resolution. This is the default value.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckReso")]
                                [Validation(Required=false)]
                                public string IsCheckReso { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video resolution. You can specify only one of the IsCheckReso and IsCheckResoFail parameters. The priority of the IsCheckResoFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the width or height of the input video is less than that of the output video, the transcoding job fails.</description></item>
                                /// <item><description>false: does not check the video resolution. This is the default value.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckResoFail")]
                                [Validation(Required=false)]
                                public string IsCheckResoFail { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video bitrate. You can specify only one of the IsCheckVideoBitrate and IsCheckVideoBitrateFail parameters. The priority of the IsCheckVideoBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input video is less than that of the output video, the bitrate of the input video is used for transcoding.</description></item>
                                /// <item><description>false: does not check the video resolution. This is the default value.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckVideoBitrate")]
                                [Validation(Required=false)]
                                public string IsCheckVideoBitrate { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video bitrate. You can specify only one of the IsCheckVideoBitrate and IsCheckVideoBitrateFail parameters. The priority of the IsCheckVideoBitrateFail parameter is higher. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true: checks the video resolution. If the bitrate of the input video is less than that of the output video, the transcoding job fails.</description></item>
                                /// <item><description>false: does not check the video resolution. This is the default value.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckVideoBitrateFail")]
                                [Validation(Required=false)]
                                public string IsCheckVideoBitrateFail { get; set; }

                                /// <summary>
                                /// <para>The video transcoding mode. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>onepass: You can set this parameter to onepass if the Bitrate parameter is set to ABR. This is the default value. The encoding speed of this mode is faster than that of the twopass mode.</description></item>
                                /// <item><description>twopass: You can set this parameter to twopass if the Bitrate parameter is set to VBR. The encoding speed of this mode is slower than that of the onepass mode.</description></item>
                                /// <item><description>CBR: the constant bitrate mode.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>onepass</para>
                                /// </summary>
                                [NameInMap("TransMode")]
                                [Validation(Required=false)]
                                public string TransMode { get; set; }

                            }

                            /// <summary>
                            /// <para>The video settings.</para>
                            /// </summary>
                            [NameInMap("Video")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                                /// <summary>
                                /// <para>The maximum ABR. This parameter takes effect only for Narrowband HD 1.0. Valid values: [10,50000]. Unit: Kbit/s.</para>
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
                                /// <item><description>Default value: 23 if the encoding format is H.264, or Default value when the Codec parameter is set to H.265: 26.</description></item>
                                /// </list>
                                /// <para>If this parameter is specified, the value of Bitrate becomes invalid.</para>
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
                                /// <para>Specifies whether to enable the auto-rotate screen feature.</para>
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
                                /// <para>Specifies whether to remove the video.</para>
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
                /// <para>The scheduling information about the job.</para>
                /// </summary>
                [NameInMap("ScheduleConfig")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig ScheduleConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig : TeaModel {
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
                /// <para>The state of the transcoding job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Init: The job is submitted.</description></item>
                /// <item><description>Processing: The job is in progress.</description></item>
                /// <item><description>Success: The job is successful.</description></item>
                /// <item><description>Fail: The job failed.</description></item>
                /// <item><description>Deleted: The job is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Init</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The job submission result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("SubmitResultJson")]
                [Validation(Required=false)]
                public Dictionary<string, object> SubmitResultJson { get; set; }

                /// <summary>
                /// <para>The time when the job was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T08:49:41Z</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

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
            /// <para>The source of the job. Valid values: API, WorkFlow, and Console.</para>
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

    }

}
