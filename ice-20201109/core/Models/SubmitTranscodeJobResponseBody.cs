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
            /// <para>The time when the job was created. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job finished. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The input group for the job. A single input creates a transcoding job. Multiple inputs create a job to merge audio and video streams.</para>
            /// </summary>
            [NameInMap("InputGroup")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobInputGroup> InputGroup { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobInputGroup : TeaModel {
                /// <summary>
                /// <para>The value of the media asset:</para>
                /// <list type="bullet">
                /// <item><description><para>If type is OSS, this is a URL. Both the OSS and HTTP protocols are supported.</para>
                /// </description></item>
                /// <item><description><para>If type is Media, this is the media asset ID.</para>
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
                /// <para>The type of the media object.
                /// Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>OSS: an OSS file.</para>
                /// </description></item>
                /// <item><description><para>Media: a media asset ID.</para>
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
            /// <para>The name of the job.</para>
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
                /// <para>The output media configuration.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput Output { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput : TeaModel {
                    /// <summary>
                    /// <para>The value of the media asset:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If type is set to OSS, the value is a URL. The OSS and HTTP protocols are supported.</para>
                    /// </description></item>
                    /// <item><description><para>If type is set to Media, the value is the media asset ID.</para>
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
                    /// <para>The media object type.
                    /// Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>OSS: An OSS file.</para>
                    /// </description></item>
                    /// <item><description><para>Media: A media asset ID.</para>
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
                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig ProcessConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig : TeaModel {
                    /// <summary>
                    /// <para>The settings for combining multiple input streams.</para>
                    /// </summary>
                    [NameInMap("CombineConfigs")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigCombineConfigs> CombineConfigs { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigCombineConfigs : TeaModel {
                        /// <summary>
                        /// <para>The index of the audio stream.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0 或 exclude</para>
                        /// </summary>
                        [NameInMap("AudioIndex")]
                        [Validation(Required=false)]
                        public string AudioIndex { get; set; }

                        /// <summary>
                        /// <para>The duration of the input stream. By default, this is the duration of the video.</para>
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
                        /// <para>0 或 exclude</para>
                        /// </summary>
                        [NameInMap("VideoIndex")]
                        [Validation(Required=false)]
                        public string VideoIndex { get; set; }

                    }

                    /// <summary>
                    /// <para>The encryption configuration.</para>
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigEncryption Encryption { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigEncryption : TeaModel {
                        /// <summary>
                        /// <para>The ciphertext of the key for standard encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MTYi00NDU0LTg5O****</para>
                        /// </summary>
                        [NameInMap("CipherText")]
                        [Validation(Required=false)]
                        public string CipherText { get; set; }

                        /// <summary>
                        /// <para>The decryption endpoint for standard encryption.</para>
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

                        /// <summary>
                        /// <para>The type of the key service. Only KMS and Base64 are supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KMS</para>
                        /// </summary>
                        [NameInMap("KeyServiceType")]
                        [Validation(Required=false)]
                        public string KeyServiceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The image watermark settings.</para>
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The parameters that, when specified, overwrite the corresponding parameters in the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The horizontal offset of the watermark image relative to the output video.
                            /// Default: 0</para>
                            /// <para>The value can be specified in two formats:</para>
                            /// <list type="bullet">
                            /// <item><description><para>An integer that specifies the offset in pixels.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: [8, 4096]</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>A decimal that specifies the ratio of the horizontal offset to the width of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: (0, 1)</para>
                            /// </description></item>
                            /// <item><description><para>The value can have up to four decimal places, such as 0.9999. The system automatically discards any digits beyond the fourth decimal place.</para>
                            /// </description></item>
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
                            /// <para>The vertical offset of the watermark image relative to the output video.
                            /// Default value: 0.</para>
                            /// <para>The value can be in one of the following two formats:</para>
                            /// <list type="bullet">
                            /// <item><description><para>An integer that specifies the offset in pixels.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: [8, 4096].</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px.</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>A decimal that specifies the ratio of the vertical offset to the output video height.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: (0, 1).</para>
                            /// </description></item>
                            /// <item><description><para>The value supports up to four decimal places, such as 0.9999. Any additional digits are automatically discarded.</para>
                            /// </description></item>
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
                            /// <para>The image file for the watermark.</para>
                            /// </summary>
                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                                /// <summary>
                                /// <para>The value of the media asset:</para>
                                /// <list type="bullet">
                                /// <item><description><para>If type is OSS, the value is a URL that supports the OSS and HTTP protocols.</para>
                                /// </description></item>
                                /// <item><description><para>If type is Media, the value is the media asset ID.</para>
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
                                /// <para>The object type of the media asset.
                                /// Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><para>OSS: An OSS file.</para>
                                /// </description></item>
                                /// <item><description><para>Media: A media asset ID.</para>
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
                            /// <para>The height of the image watermark on the output video.
                            /// The value can be specified in two ways:</para>
                            /// <list type="bullet">
                            /// <item><description><para>An integer that represents the watermark height in pixels.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: [8, 4096].</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px.</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>A decimal that represents the watermark height as a ratio of the output video\&quot;s height.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: (0, 1).</para>
                            /// </description></item>
                            /// <item><description><para>The value supports up to four decimal places, such as 0.9999. Digits beyond the fourth decimal place are automatically discarded.</para>
                            /// </description></item>
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
                            /// <item><description><para>Valid values: TopRight, TopLeft, BottomRight, and BottomLeft.</para>
                            /// </description></item>
                            /// <item><description><para>Default value: TopRight.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TopLeft</para>
                            /// </summary>
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            /// <summary>
                            /// <para>The display time settings for the dynamic watermark.</para>
                            /// </summary>
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                /// <summary>
                                /// <para>The duration of the watermark.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: [Number, ToEND]</para>
                                /// </description></item>
                                /// <item><description><para>Default value: ToEND</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ToEND</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The time when the watermark appears.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Unit: seconds</para>
                                /// </description></item>
                                /// <item><description><para>The value must be numeric.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 0</para>
                                /// </description></item>
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
                            /// <para>The width of the watermark image on the output video.
                            /// The value can be specified in two formats:</para>
                            /// <list type="bullet">
                            /// <item><description><para>An integer that specifies the width of the watermark image in pixels.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: [8, 4096].</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px.</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>A decimal that represents the width of the watermark relative to the width of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: (0, 1).</para>
                            /// </description></item>
                            /// <item><description><para>The value supports up to four decimal places, such as 0.9999. Digits beyond the fourth decimal place are automatically discarded.</para>
                            /// </description></item>
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
                    /// <para>The caption burn-in configuration.</para>
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// <para>The overwrite parameters. If specified, these parameters overwrite the corresponding parameters in the template.</para>
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
                                /// <para>The value of the media asset. If the type is OSS, the value is a URL that supports the OSS and HTTP protocols. If the type is Media, the value is the media asset ID.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>oss://bucket/path/to/video.mp4</para>
                                /// </summary>
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }

                                /// <summary>
                                /// <para>The type of the media object.
                                /// Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><para>OSS: an OSS file.</para>
                                /// </description></item>
                                /// <item><description><para>Media: a media asset ID.</para>
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
                            /// <para>The caption file format.</para>
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
                    /// <para>The text watermark configurations.</para>
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// <para>The overwrite parameters. If specified, these parameters overwrite the corresponding parameters in the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>Adjusts the font size based on the size of the output video.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: true, false</para>
                            /// </description></item>
                            /// <item><description><para>default: false</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }

                            /// <summary>
                            /// <para>The outline color.
                            /// Default: Black
                            /// For more values, see BorderColor.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }

                            /// <summary>
                            /// <para>The width of the border.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Default: 0</para>
                            /// </description></item>
                            /// <item><description><para>Range: (0, 4096]</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("BorderWidth")]
                            [Validation(Required=false)]
                            public int? BorderWidth { get; set; }

                            /// <summary>
                            /// <para>The watermark text. The string must be UTF-8 encoded. Base64 encoding is not required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>测试水印</para>
                            /// </summary>
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The transparency of the font.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Range: (0, 1].</para>
                            /// </description></item>
                            /// <item><description><para>Default: 1.0.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.0</para>
                            /// </summary>
                            [NameInMap("FontAlpha")]
                            [Validation(Required=false)]
                            public string FontAlpha { get; set; }

                            /// <summary>
                            /// <para>The font color.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("FontColor")]
                            [Validation(Required=false)]
                            public string FontColor { get; set; }

                            /// <summary>
                            /// <para>The font. Default: SimSun.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SimSun</para>
                            /// </summary>
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }

                            /// <summary>
                            /// <para>The font size.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Default value: 16</para>
                            /// </description></item>
                            /// <item><description><para>Range: (4, 120)</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }

                            /// <summary>
                            /// <para>The left margin of the text.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Default: 0</para>
                            /// </description></item>
                            /// <item><description><para>Range: [0,4096]</para>
                            /// </description></item>
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
                            /// <item><description><para>Default: 0.</para>
                            /// </description></item>
                            /// <item><description><para>Range: [0,4096].</para>
                            /// </description></item>
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
                        /// <para>The overwrite parameters. If specified, these parameters overwrite the corresponding parameters in the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>Audio settings.</para>
                            /// </summary>
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                                /// <summary>
                                /// <para>The audio bitrate of the output file.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Value range: [8, 1000]</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbps</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 128</para>
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
                                /// <para>The number of sound channels.
                                /// Default value: 2.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Channels")]
                                [Validation(Required=false)]
                                public string Channels { get; set; }

                                /// <summary>
                                /// <para>The audio codec format. Valid values are AAC, MP3, VORBIS, and FLAC.
                                /// Default value: AAC</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AAC</para>
                                /// </summary>
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }

                                /// <summary>
                                /// <para>The audio encoding preset.
                                /// When Codec is set to AAC, valid values are aac_low, aac_he, aac_he_v2, aac_ld, and aac_eld.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>aac_low</para>
                                /// </summary>
                                [NameInMap("Profile")]
                                [Validation(Required=false)]
                                public string Profile { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to remove the audio stream.</para>
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
                                /// <item><description><para>Default value: 44100. Valid values: 22050, 32000, 44100, 48000, and 96000.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Hz</para>
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
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                    /// <summary>
                                    /// <para>The target volume.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>-6</para>
                                    /// </summary>
                                    [NameInMap("IntegratedLoudnessTarget")]
                                    [Validation(Required=false)]
                                    public string IntegratedLoudnessTarget { get; set; }

                                    /// <summary>
                                    /// <para>The loudness range.</para>
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
                                    /// <para>The true peak.</para>
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
                                /// <para>Segment settings.</para>
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
                                    /// <para>The time points for forced segmentation.</para>
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
                            /// <para>The conditional transcoding parameters.</para>
                            /// </summary>
                            [NameInMap("TransConfig")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
                                /// <summary>
                                /// <para>The method to adjust the resolution. This setting takes effect only when both Width and Height are specified. It can be used with LongShortMode.</para>
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
                                /// <para>Specifies whether to check the audio bitrate. You can set either this parameter or IsCheckAudioBitrateFail. IsCheckAudioBitrateFail takes precedence.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Checks the audio bitrate. If the input audio bitrate is lower than the configured output bitrate, the service uses the input audio bitrate for transcoding.</para>
                                /// </description></item>
                                /// <item><description><para>false: Does not check the audio bitrate.</para>
                                /// </description></item>
                                /// </list>
                                /// <para>Default value:</para>
                                /// <list type="bullet">
                                /// <item><description><para>false: If this parameter is empty and the output codec is different from the input codec.</para>
                                /// </description></item>
                                /// <item><description><para>true: If this parameter is empty and the output codec is the same as the input codec.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckAudioBitrate")]
                                [Validation(Required=false)]
                                public string IsCheckAudioBitrate { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the audio bitrate. You can set either IsCheckAudioBitrate or IsCheckAudioBitrateFail. This parameter has a higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: The transcoding job fails if the input audio bitrate is lower than the output bitrate setting.</para>
                                /// </description></item>
                                /// <item><description><para>false: The audio bitrate is not checked.</para>
                                /// </description></item>
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
                                /// <para>Specifies whether to check the video resolution. The IsCheckReso and IsCheckResoFail parameters are mutually exclusive. IsCheckResoFail takes precedence.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Enables the resolution check. If the resolution (width or height) of the input video is lower than the output resolution, the transcoding job uses the input resolution.</para>
                                /// </description></item>
                                /// <item><description><para>false: Disables the resolution check.</para>
                                /// </description></item>
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
                                /// <para>Specifies whether to check the video resolution. You can use either IsCheckReso or IsCheckResoFail, but not both. This parameter has a higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Checks the resolution. The transcoding job fails if the width or height of the input video is smaller than the output resolution.</para>
                                /// </description></item>
                                /// <item><description><para>false: Does not check the resolution.</para>
                                /// </description></item>
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
                                /// <para>Specifies whether to check the video bitrate. You can set either IsCheckVideoBitrate or IsCheckVideoBitrateFail. IsCheckVideoBitrateFail has a higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Checks the bitrate. If the input video bitrate is lower than the output bitrate, the video is transcoded at the input bitrate.</para>
                                /// </description></item>
                                /// <item><description><para>false: Does not check the bitrate.</para>
                                /// </description></item>
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
                                /// <para>Specifies whether to check the video bitrate. This parameter and IsCheckVideoBitrate are mutually exclusive. IsCheckVideoBitrateFail has a higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Enables the check. The transcoding job fails if the input video bitrate is lower than the output bitrate setting.</para>
                                /// </description></item>
                                /// <item><description><para>false: Disables the check.</para>
                                /// </description></item>
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
                                /// <item><description><para>onepass: Typically used for ABR. The encoding speed is faster than twopass.</para>
                                /// </description></item>
                                /// <item><description><para>twopass: Typically used for VBR. The encoding speed is slower than onepass.</para>
                                /// </description></item>
                                /// <item><description><para>CBR: Constant Bitrate mode.</para>
                                /// </description></item>
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
                            /// <para>Video settings</para>
                            /// </summary>
                            [NameInMap("Video")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                                /// <summary>
                                /// <para>The maximum bitrate for adaptive bitrate (ABR) streaming. This parameter is valid only for Narrowband HD 1.0.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Value range: [10, 50000]</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbps</para>
                                /// </description></item>
                                /// </list>
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
                                /// <item><description><para>Value range: [10, 50000].</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbps.</para>
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
                                /// <item><description><para>Value range: [1000, 128000]</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 6000</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kb</para>
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
                                /// <para>The encoding format.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>H.264</para>
                                /// </summary>
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }

                                /// <summary>
                                /// <para>The Constant Rate Factor (CRF).</para>
                                /// <list type="bullet">
                                /// <item><description><para>The value can be from 0 to 51.</para>
                                /// </description></item>
                                /// <item><description><para>The default value is 23 for H264 encoding and 26 for H265 encoding.</para>
                                /// </description></item>
                                /// </list>
                                /// <para>If Crf is set, the Bitrate setting is ignored.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>23</para>
                                /// </summary>
                                [NameInMap("Crf")]
                                [Validation(Required=false)]
                                public string Crf { get; set; }

                                /// <summary>
                                /// <para>Crops the video frame.
                                /// Two methods are available.</para>
                                /// <list type="bullet">
                                /// <item><description><para>To automatically detect and crop black bars, set the parameter to &quot;border&quot;.</para>
                                /// </description></item>
                                /// <item><description><para>To specify a custom crop area, use the width:height:left:top format.
                                /// Example: 1280:800:0:140</para>
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
                                /// <item><description><para>Valid values: (0, 60].</para>
                                /// </description></item>
                                /// <item><description><para>If the input file has a frame rate greater than 60, the frame rate is capped at 60.</para>
                                /// </description></item>
                                /// <item><description><para>Default: The frame rate of the input file.</para>
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
                                /// <para>The maximum number of frames between two keyframes.</para>
                                /// <list type="bullet">
                                /// <item><description><para>The value must be in the range of [1, 1080000].</para>
                                /// </description></item>
                                /// <item><description><para>The default value is 250.</para>
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
                                /// <para>The height of the video.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: [128, 4096].</para>
                                /// </description></item>
                                /// <item><description><para>Unit: px.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: The original height of the video.</para>
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
                                /// <para>Specifies whether to enable automatic rotation for landscape and portrait orientations (long and short edge pattern).</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("LongShortMode")]
                                [Validation(Required=false)]
                                public string LongShortMode { get; set; }

                                /// <summary>
                                /// <para>The peak video bitrate.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Value range: [10, 50000]</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbps</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>9000</para>
                                /// </summary>
                                [NameInMap("Maxrate")]
                                [Validation(Required=false)]
                                public string Maxrate { get; set; }

                                /// <summary>
                                /// <para>Adds black bars to the video.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Format: width:height:left:top</para>
                                /// </description></item>
                                /// <item><description><para>Example: 1280:800:0:140</para>
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
                                /// <para>The pixel format of the video. Valid values include standard formats such as yuv420p and yuvj420p.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>yuv420p</para>
                                /// </summary>
                                [NameInMap("PixFmt")]
                                [Validation(Required=false)]
                                public string PixFmt { get; set; }

                                /// <summary>
                                /// <para>The video algorithm preset. This parameter is supported only for H.264. Supported values are veryfast, fast, medium, slow, and slower. The default value is medium.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>medium</para>
                                /// </summary>
                                [NameInMap("Preset")]
                                [Validation(Required=false)]
                                public string Preset { get; set; }

                                /// <summary>
                                /// <para>The encoding profile.
                                /// Supported values are baseline, main, and high.</para>
                                /// <list type="bullet">
                                /// <item><description><para>baseline: For mobile devices.</para>
                                /// </description></item>
                                /// <item><description><para>main: For standard-resolution devices.</para>
                                /// </description></item>
                                /// <item><description><para>high: For high-resolution devices.</para>
                                /// </description></item>
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
                                /// <para>The scan mode. Valid values are interlaced and progressive.</para>
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
                                /// <item><description><para>Valid values: 128 to 4096.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: px.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: The original width of the video.</para>
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
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The ID of the parent job.</para>
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
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The job scheduling configuration.</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public SubmitTranscodeJobResponseBodyTranscodeParentJobScheduleConfig ScheduleConfig { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobScheduleConfig : TeaModel {
                /// <summary>
                /// <para>The pipeline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
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
            /// <para>The status of the job. Success: At least one sub-job succeeded after all sub-jobs are complete. Fail: All sub-jobs failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The list of sub-jobs.</para>
            /// </summary>
            [NameInMap("TranscodeJobList")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList> TranscodeJobList { get; set; }
            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList : TeaModel {
                /// <summary>
                /// <para>The time the job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T08:49:41Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the job finished.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-12T08:49:41Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The input group for the job. A single input creates a transcoding job. Multiple inputs create a media merging job.</para>
                /// </summary>
                [NameInMap("InputGroup")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup> InputGroup { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup : TeaModel {
                    /// <summary>
                    /// <para>The input stream path:</para>
                    /// <list type="bullet">
                    /// <item><description><para>This parameter takes effect only when Type is Media. It lets you select a specific file from the media asset as the input.</para>
                    /// </description></item>
                    /// <item><description><para>The system checks whether the input URL exists in the media asset.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("InputUrl")]
                    [Validation(Required=false)]
                    public string InputUrl { get; set; }

                    /// <summary>
                    /// <para>The media value:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If Type is OSS, this is a URL that supports the OSS or HTTP protocol.</para>
                    /// </description></item>
                    /// <item><description><para>If Type is Media, this is a media asset ID.</para>
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
                    /// <para>The media object type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>OSS: An OSS file.</para>
                    /// </description></item>
                    /// <item><description><para>Media: A media asset ID.</para>
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
                /// <para>The sub-job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7d6a7e0d4db2457a8d45ff5d43e1bf0a</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The index of the sub-job within the entire job.</para>
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
                /// <para>The media information of the video generated by the job.</para>
                /// </summary>
                [NameInMap("OutFileMeta")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta OutFileMeta { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta : TeaModel {
                    /// <summary>
                    /// <para>The audio stream information.</para>
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
                        /// <para>The channel layout.</para>
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
                        /// <para>The encoder tag name.</para>
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
                        /// <para>The duration in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>403.039989</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>The index of the stream.</para>
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
                        /// <para>cn</para>
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

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
                        /// <para>The sample rate in Hz.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>44100</para>
                        /// </summary>
                        [NameInMap("SampleRate")]
                        [Validation(Required=false)]
                        public string SampleRate { get; set; }

                        /// <summary>
                        /// <para>The start time.</para>
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
                    /// <para>Basic file information.</para>
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
                        /// <para>The duration of the video in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>403.039999</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <para>The name of the file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>file.m3u8</para>
                        /// </summary>
                        [NameInMap("FileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        /// <summary>
                        /// <para>The size of the file in bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>31737</para>
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
                        /// <para>The height.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>478</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The media asset ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>73e07de0f77171eca3fc7035d0b26402</para>
                        /// </summary>
                        [NameInMap("MediaId")]
                        [Validation(Required=false)]
                        public string MediaId { get; set; }

                        /// <summary>
                        /// <para>The region where the file is located.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-shanghai</para>
                        /// </summary>
                        [NameInMap("Region")]
                        [Validation(Required=false)]
                        public string Region { get; set; }

                        /// <summary>
                        /// <para>The width of the output file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>848</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// <para>The video stream information.</para>
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
                        /// <para>The encoding format tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0x001b</para>
                        /// </summary>
                        [NameInMap("Codec_tag")]
                        [Validation(Required=false)]
                        public string CodecTag { get; set; }

                        /// <summary>
                        /// <para>The text of the encoding format tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[27][0][0][0]</para>
                        /// </summary>
                        [NameInMap("Codec_tag_string")]
                        [Validation(Required=false)]
                        public string CodecTagString { get; set; }

                        /// <summary>
                        /// <para>The codec time base.</para>
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
                        /// <para>The duration in seconds.</para>
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
                        /// <para>Indicates whether B-frames exist.
                        /// Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>0: No B-frames.</para>
                        /// </description></item>
                        /// <item><description><para>1: One B-frame.</para>
                        /// </description></item>
                        /// <item><description><para>2: Multiple consecutive B-frames.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Has_b_frames")]
                        [Validation(Required=false)]
                        public string HasBFrames { get; set; }

                        /// <summary>
                        /// <para>The height of the output video stream.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>478</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <para>The index of the stream.</para>
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
                        /// <para>cn</para>
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

                        /// <summary>
                        /// <para>The encoding level.</para>
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
                        /// <para>The color storage format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yuv420p</para>
                        /// </summary>
                        [NameInMap("PixFmt")]
                        [Validation(Required=false)]
                        public string PixFmt { get; set; }

                        /// <summary>
                        /// <para>The encoder preset.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>High</para>
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// <para>The rotation angle of the video. Valid values: 0, 90, 180, and 270. The default value is 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Rotate")]
                        [Validation(Required=false)]
                        public string Rotate { get; set; }

                        /// <summary>
                        /// <para>The sample aspect ratio.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>478:477</para>
                        /// </summary>
                        [NameInMap("Sar")]
                        [Validation(Required=false)]
                        public string Sar { get; set; }

                        /// <summary>
                        /// <para>The start time.</para>
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
                        /// <para>The video width.</para>
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
                /// <para>The output media configuration.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput Output { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput : TeaModel {
                    /// <summary>
                    /// <para>The value of the media asset:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If type is OSS, the value is a URL. The OSS and HTTP protocols are supported.</para>
                    /// </description></item>
                    /// <item><description><para>If type is Media, the value is the media asset ID.</para>
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
                    /// <para>The path of the output stream.<br>
                    /// This parameter is valid only when \<c>Type\\</c> is set to \<c>Media\\</c>. It lets you select a specific file from the media asset for output.<br>
                    /// The following placeholders are supported:<br><br></para>
                    /// <list type="bullet">
                    /// <item><description><para>{MediaId}: The ID of the media asset.</para>
                    /// </description></item>
                    /// <item><description><para>{JobId}: The ID of the transcoding subtask.</para>
                    /// </description></item>
                    /// <item><description><para>{MediaBucket}: The bucket where the media asset is stored.</para>
                    /// </description></item>
                    /// <item><description><para>{ExtName}: The file extension. The value is the output format specified in the transcoding template.</para>
                    /// </description></item>
                    /// <item><description><para>{DestMd5}: The MD5 hash of the output file.<br>
                    /// Note:<br></para>
                    /// </description></item>
                    /// </list>
                    /// <ol>
                    /// <item><description><para>This parameter must contain the {MediaId} and {JobId} placeholders.</para>
                    /// </description></item>
                    /// <item><description><para>The output bucket is the same as the bucket where the media asset is stored.</para>
                    /// </description></item>
                    /// </ol>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/{MediaId}/{JobId}.mp4</para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                    /// <summary>
                    /// <para>The media object type.
                    /// Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>OSS: An OSS file.</para>
                    /// </description></item>
                    /// <item><description><para>Media: A media asset ID.</para>
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
                /// <para>The parent job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8b2198504dd340b7b3c9842a74fc9baa</para>
                /// </summary>
                [NameInMap("ParentJobId")]
                [Validation(Required=false)]
                public string ParentJobId { get; set; }

                /// <summary>
                /// <para>The transcoding processing configuration.</para>
                /// </summary>
                [NameInMap("ProcessConfig")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig ProcessConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration for mixing multiple input streams.</para>
                    /// </summary>
                    [NameInMap("CombineConfigs")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigCombineConfigs> CombineConfigs { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigCombineConfigs : TeaModel {
                        /// <summary>
                        /// <para>The index of the audio stream.</para>
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
                        /// <para>0 或 exclude</para>
                        /// </summary>
                        [NameInMap("VideoIndex")]
                        [Validation(Required=false)]
                        public string VideoIndex { get; set; }

                    }

                    /// <summary>
                    /// <para>The encryption configuration.</para>
                    /// </summary>
                    [NameInMap("Encryption")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigEncryption Encryption { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigEncryption : TeaModel {
                        /// <summary>
                        /// <para>The ciphertext of the key for standard encryption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MTYi00NDU0LTg5O****</para>
                        /// </summary>
                        [NameInMap("CipherText")]
                        [Validation(Required=false)]
                        public string CipherText { get; set; }

                        /// <summary>
                        /// <para>The decryption service endpoint for standard encryption.</para>
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

                        /// <summary>
                        /// <para>The type of the key service. Only KMS and Base64 are supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KMS</para>
                        /// </summary>
                        [NameInMap("KeyServiceType")]
                        [Validation(Required=false)]
                        public string KeyServiceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The image watermark configuration.</para>
                    /// </summary>
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks : TeaModel {
                        /// <summary>
                        /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The horizontal offset of the image watermark relative to the output video. Default value: 0.</para>
                            /// <para>Values can be one of the following:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: The offset in pixels.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: [8, 4096]</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: The ratio of the horizontal offset to the output video width.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: (0, 1)</para>
                            /// </description></item>
                            /// <item><description><para>Up to four decimal places are supported, such as 0.9999. Extra digits are automatically discarded.</para>
                            /// </description></item>
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
                            /// <para>The vertical offset of the image watermark relative to the output video. Default value: 0.</para>
                            /// <para>Values can be one of the following:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: The offset in pixels.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: [8, 4096]</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: The ratio of the vertical offset to the output video height.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: (0, 1)</para>
                            /// </description></item>
                            /// <item><description><para>Up to four decimal places are supported, such as 0.9999. Extra digits are automatically discarded.</para>
                            /// </description></item>
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
                                /// <para>The media value:</para>
                                /// <list type="bullet">
                                /// <item><description><para>If Type is OSS, this is a URL that supports the OSS or HTTP protocol.</para>
                                /// </description></item>
                                /// <item><description><para>If Type is Media, this is a media asset ID.</para>
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
                                /// <para>The media object type. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><para>OSS: An OSS file.</para>
                                /// </description></item>
                                /// <item><description><para>Media: A media asset ID.</para>
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
                            /// <para>The height of the image watermark on the output video. Values can be one of the following:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: The pixel height of the watermark image.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: [8, 4096]</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: The ratio of the watermark height to the output video height.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: (0, 1)</para>
                            /// </description></item>
                            /// <item><description><para>Up to four decimal places are supported, such as 0.9999. Extra digits are automatically discarded.</para>
                            /// </description></item>
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
                            /// <item><description><para>Valid values: TopRight (top-right), TopLeft (top-left), BottomRight (bottom-right), and BottomLeft (bottom-left).</para>
                            /// </description></item>
                            /// <item><description><para>Default value: TopRight.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TopLeft</para>
                            /// </summary>
                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            /// <summary>
                            /// <para>The display time settings for a dynamic watermark.</para>
                            /// </summary>
                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                /// <summary>
                                /// <para>The duration of the watermark.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: [number, ToEND]</para>
                                /// </description></item>
                                /// <item><description><para>Default value: ToEND</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ToEND</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <para>The start time of the watermark.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Unit: seconds</para>
                                /// </description></item>
                                /// <item><description><para>Valid values: numbers</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 0</para>
                                /// </description></item>
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
                            /// <para>The width of the image watermark on the output video. Values can be one of the following:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Integer: The pixel width of the watermark image.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: [8, 4096]</para>
                            /// </description></item>
                            /// <item><description><para>Unit: px</para>
                            /// </description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Decimal: The ratio of the watermark width to the output video width.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: (0, 1)</para>
                            /// </description></item>
                            /// <item><description><para>Up to four decimal places are supported, such as 0.9999. Extra digits are automatically discarded.</para>
                            /// </description></item>
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
                    /// <para>The configuration for burning in captions.</para>
                    /// </summary>
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles> Subtitles { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles : TeaModel {
                        /// <summary>
                        /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>The encoding format of the file.</para>
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
                                /// <para>The value of Media:</para>
                                /// <list type="bullet">
                                /// <item><description><para>If type is OSS, the value is a URL. The URL supports the OSS and HTTP protocols.</para>
                                /// </description></item>
                                /// <item><description><para>If type is Media, the value is the media asset ID.</para>
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
                                /// <para>The type of the media object.
                                /// Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><para>OSS: An OSS file.</para>
                                /// </description></item>
                                /// <item><description><para>Media: The ID of a media asset.</para>
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
                            /// <para>The file format of the caption.</para>
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
                    /// <para>The text watermark configuration.</para>
                    /// </summary>
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks : TeaModel {
                        /// <summary>
                        /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
                        /// </summary>
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams : TeaModel {
                            /// <summary>
                            /// <para>Adjusts the font size based on the output video size. The default is false.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Adaptive")]
                            [Validation(Required=false)]
                            public string Adaptive { get; set; }

                            /// <summary>
                            /// <para>The outline color.
                            /// Default: Black.
                            /// For more values, see BorderColor.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>#006400</para>
                            /// </summary>
                            [NameInMap("BorderColor")]
                            [Validation(Required=false)]
                            public string BorderColor { get; set; }

                            /// <summary>
                            /// <para>The outline width.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Default: 0</para>
                            /// </description></item>
                            /// <item><description><para>Range: (0,4096]</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("BorderWidth")]
                            [Validation(Required=false)]
                            public int? BorderWidth { get; set; }

                            /// <summary>
                            /// <para>The watermark text. It does not need to be Base64 encoded. The string must be UTF-8 encoded.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>测试水印</para>
                            /// </summary>
                            [NameInMap("Content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The font transparency.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values: (0, 1]</para>
                            /// </description></item>
                            /// <item><description><para>Default: 1.0</para>
                            /// </description></item>
                            /// </list>
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
                            /// <para>The font. Default: SimSun.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SimSun</para>
                            /// </summary>
                            [NameInMap("FontName")]
                            [Validation(Required=false)]
                            public string FontName { get; set; }

                            /// <summary>
                            /// <para>The font size.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Default value: 16</para>
                            /// </description></item>
                            /// <item><description><para>Valid values: (4, 120)</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16</para>
                            /// </summary>
                            [NameInMap("FontSize")]
                            [Validation(Required=false)]
                            public int? FontSize { get; set; }

                            /// <summary>
                            /// <para>The left margin of the text.</para>
                            /// <list type="bullet">
                            /// <item><description><para>Default: 0</para>
                            /// </description></item>
                            /// <item><description><para>Valid values: [0, 4096]</para>
                            /// </description></item>
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
                            /// <item><description><para>Default: 0</para>
                            /// </description></item>
                            /// <item><description><para>Valid values: [0, 4096]</para>
                            /// </description></item>
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
                        /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
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
                                /// <item><description><para>Valid values: [8, 1000]</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbps</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 128</para>
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
                                /// <para>The audio encoding profile. When Codec is AAC, valid values are aac_low, aac_he, aac_he_v2, aac_ld, and aac_eld.</para>
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
                                /// <para>The sample rate.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Default value: 44100</para>
                                /// </description></item>
                                /// <item><description><para>Valid values: 22050, 32000, 44100, 48000, and 96000.</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Hz</para>
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
                                /// <para>The volume control.</para>
                                /// </summary>
                                [NameInMap("Volume")]
                                [Validation(Required=false)]
                                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                    /// <summary>
                                    /// <para>The target loudness level.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>-6</para>
                                    /// </summary>
                                    [NameInMap("IntegratedLoudnessTarget")]
                                    [Validation(Required=false)]
                                    public string IntegratedLoudnessTarget { get; set; }

                                    /// <summary>
                                    /// <para>The loudness range.</para>
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
                            /// <para>The multiplexing settings.</para>
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
                                    /// <para>The segment duration.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>10</para>
                                    /// </summary>
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }

                                    /// <summary>
                                    /// <para>The forced segment time points.</para>
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
                            /// <para>The conditional transcoding parameters.</para>
                            /// </summary>
                            [NameInMap("TransConfig")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                            public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
                                /// <summary>
                                /// <para>The method used to adjust the display aspect ratio. This parameter takes effect only when both Width and Height are specified. You can use it with LongShortMode.</para>
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
                                /// <para>Specifies whether to check the audio bitrate. IsCheckAudioBitrate and IsCheckAudioBitrateFail are mutually exclusive. IsCheckAudioBitrateFail has higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Check the bitrate. If the input audio bitrate is lower than the output setting, transcode at the input bitrate.</para>
                                /// </description></item>
                                /// <item><description><para>false: Do not check the bitrate.</para>
                                /// </description></item>
                                /// </list>
                                /// <para>Default value rules:</para>
                                /// <list type="bullet">
                                /// <item><description><para>Empty and the codec differs from the input source: false.</para>
                                /// </description></item>
                                /// <item><description><para>Empty and the codec matches the input source: true.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckAudioBitrate")]
                                [Validation(Required=false)]
                                public string IsCheckAudioBitrate { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the audio bitrate. IsCheckAudioBitrate and IsCheckAudioBitrateFail are mutually exclusive. This parameter has higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Check the bitrate. If the input audio bitrate is lower than the output setting, return a failure.</para>
                                /// </description></item>
                                /// <item><description><para>false (default): Do not check the bitrate.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckAudioBitrateFail")]
                                [Validation(Required=false)]
                                public string IsCheckAudioBitrateFail { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video resolution. IsCheckReso and IsCheckResoFail are mutually exclusive. IsCheckResoFail has higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Check the resolution. If the input video resolution (width or height) is smaller than the output setting, transcode at the input resolution.</para>
                                /// </description></item>
                                /// <item><description><para>false (default): Do not check the resolution.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckReso")]
                                [Validation(Required=false)]
                                public string IsCheckReso { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video resolution. IsCheckReso and IsCheckResoFail are mutually exclusive. This parameter has higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Check the resolution. If the input video resolution (width or height) is smaller than the output setting, return a failure.</para>
                                /// </description></item>
                                /// <item><description><para>false (default): Do not check the resolution.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckResoFail")]
                                [Validation(Required=false)]
                                public string IsCheckResoFail { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video bitrate. IsCheckVideoBitrate and IsCheckVideoBitrateFail are mutually exclusive. IsCheckVideoBitrateFail has higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Check the bitrate. If the input video bitrate is lower than the output setting, transcode at the input bitrate.</para>
                                /// </description></item>
                                /// <item><description><para>false (default): Do not check the bitrate.</para>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("IsCheckVideoBitrate")]
                                [Validation(Required=false)]
                                public string IsCheckVideoBitrate { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to check the video bitrate. IsCheckVideoBitrate and IsCheckVideoBitrateFail are mutually exclusive. This parameter has higher priority.</para>
                                /// <list type="bullet">
                                /// <item><description><para>true: Check the bitrate. If the input video bitrate is lower than the output setting, return a failure.</para>
                                /// </description></item>
                                /// <item><description><para>false (default): Do not check the bitrate.</para>
                                /// </description></item>
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
                                /// <item><description><para>onepass (default): Used for ABR. Encoding is faster than twopass.</para>
                                /// </description></item>
                                /// <item><description><para>twopass: Used for VBR. Encoding is slower than onepass.</para>
                                /// </description></item>
                                /// <item><description><para>CBR: Constant bitrate mode.</para>
                                /// </description></item>
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
                                /// <para>The maximum bitrate for adaptive bitrate streaming (ABR). This applies only to narrow-high 1. Valid values: [10, 50000]. Unit: Kbps.</para>
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
                                /// <item><description><para>Valid values: [10, 50000].</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kbps.</para>
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
                                /// <item><description><para>Valid values: [1000, 128000]</para>
                                /// </description></item>
                                /// <item><description><para>Default value: 6000</para>
                                /// </description></item>
                                /// <item><description><para>Unit: Kb</para>
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
                                /// <para>The encoding format.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>H.264</para>
                                /// </summary>
                                [NameInMap("Codec")]
                                [Validation(Required=false)]
                                public string Codec { get; set; }

                                /// <summary>
                                /// <para>The constant rate factor (CRF), which controls the trade-off between quality and bitrate.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: [0, 51].</para>
                                /// </description></item>
                                /// <item><description><para>Default values: 23 for H.264 and 26 for H.265.</para>
                                /// </description></item>
                                /// </list>
                                /// <para>If you set Crf, the Bitrate setting is ignored.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>23</para>
                                /// </summary>
                                [NameInMap("Crf")]
                                [Validation(Required=false)]
                                public string Crf { get; set; }

                                /// <summary>
                                /// <para>The video cropping method. Two options are available.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Automatically detect and crop black bars. Set this to border.</para>
                                /// </description></item>
                                /// <item><description><para>Custom cropping. Format: width:height:left:top. Example: 1280:800:0:140</para>
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
                                /// <item><description><para>Valid values: (0, 60].</para>
                                /// </description></item>
                                /// <item><description><para>If the frame rate of the input file exceeds 60, the system uses 60.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: The frame rate of the input file.</para>
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
                                /// <para>The maximum number of frames between keyframes.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: [1, 1080000].</para>
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
                                /// <item><description><para>Valid values: [128, 4096].</para>
                                /// </description></item>
                                /// <item><description><para>Unit: px.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: The original video height.</para>
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
                                /// <para>Specifies whether to enable automatic rotation for portrait or landscape videos (also known as long-side/short-side mode).</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>false</para>
                                /// </summary>
                                [NameInMap("LongShortMode")]
                                [Validation(Required=false)]
                                public string LongShortMode { get; set; }

                                /// <summary>
                                /// <para>The peak video bitrate. Valid values: [10, 50000]. Unit: Kbps.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>9000</para>
                                /// </summary>
                                [NameInMap("Maxrate")]
                                [Validation(Required=false)]
                                public string Maxrate { get; set; }

                                /// <summary>
                                /// <para>The padding configuration for black bars.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Format: width:height:left:top.</para>
                                /// </description></item>
                                /// <item><description><para>Example: 1280:800:0:140</para>
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
                                /// <para>The video color format. Valid values include yuv420p and yuvj420p.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>yuv420p</para>
                                /// </summary>
                                [NameInMap("PixFmt")]
                                [Validation(Required=false)]
                                public string PixFmt { get; set; }

                                /// <summary>
                                /// <para>The video encoder preset. Only H.264 supports this parameter. Valid values: veryfast, fast, medium, slow, and slower. Default value: medium.</para>
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
                                /// <item><description><para>baseline: For mobile devices.</para>
                                /// </description></item>
                                /// <item><description><para>main: For standard-resolution devices.</para>
                                /// </description></item>
                                /// <item><description><para>high: For high-resolution devices.</para>
                                /// </description></item>
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
                                /// <para>The width.</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values: [128, 4096].</para>
                                /// </description></item>
                                /// <item><description><para>Unit: px.</para>
                                /// </description></item>
                                /// <item><description><para>Default value: The original video width.</para>
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
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the request to submit the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The scheduling information for the job.</para>
                /// </summary>
                [NameInMap("ScheduleConfig")]
                [Validation(Required=false)]
                public SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig ScheduleConfig { get; set; }
                public class SubmitTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig : TeaModel {
                    /// <summary>
                    /// <para>The ID of the pipeline.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
                    /// </summary>
                    [NameInMap("PipelineId")]
                    [Validation(Required=false)]
                    public string PipelineId { get; set; }

                    /// <summary>
                    /// <para>The priority of the task. A larger value indicates a higher priority. The value can be an integer from 1 to 10.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                }

                /// <summary>
                /// <para>The status of the transcoding job.</para>
                /// <list type="bullet">
                /// <item><description><para>Init: The job is submitted.</para>
                /// </description></item>
                /// <item><description><para>Processing: The job is being transcoded.</para>
                /// </description></item>
                /// <item><description><para>Success: The transcoding is successful.</para>
                /// </description></item>
                /// <item><description><para>Fail: The transcoding failed.</para>
                /// </description></item>
                /// <item><description><para>Deleted: The job is deleted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Init</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The result of the job submission.</para>
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
                /// <para>User data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-data</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The source of the job. Valid values: \<c>API\\</c>, \<c>WorkFlow\\</c>, and \<c>Console\\</c>.</para>
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
