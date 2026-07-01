// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobRequest : TeaModel {
        /// <summary>
        /// <para>The idempotence key. Ensures request idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The input group for the job. A single input creates a transcoding job. Multiple inputs create a media merging job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("InputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestInputGroup> InputGroup { get; set; }
        public class SubmitTranscodeJobRequestInputGroup : TeaModel {
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
            /// <item><description>If Type is OSS, this is a URL that supports the OSS or HTTP protocol.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must add the OSS bucket in the URL to IMS <a href="https://help.aliyun.com/document_detail/609918.html">storage management</a> before you use it.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If Type is Media, this is a media asset ID.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output group for the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("OutputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestOutputGroup> OutputGroup { get; set; }
        public class SubmitTranscodeJobRequestOutputGroup : TeaModel {
            /// <summary>
            /// <para>The output media configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupOutput Output { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupOutput : TeaModel {
                /// <summary>
                /// <para>The media value:</para>
                /// <list type="bullet">
                /// <item><description>If Type is OSS, this is a URL that supports the OSS or HTTP protocol.</description></item>
                /// </list>
                /// <remarks>
                /// <para>You must add the OSS bucket in the URL to IMS <a href="https://help.aliyun.com/document_detail/609918.html">storage management</a> before you use it.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>If Type is Media, this is a media asset ID.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The output stream path:<br>
                /// This parameter takes effect only when Type is Media. It lets you select a specific file from the media asset as the output.<br>
                /// Valid placeholders:<br><br></para>
                /// <list type="bullet">
                /// <item><description><para>{MediaId}: The media asset ID.</para>
                /// </description></item>
                /// <item><description><para>{JobId}: The sub-job ID.</para>
                /// </description></item>
                /// <item><description><para>{MediaBucket}: The bucket where the media asset resides.</para>
                /// </description></item>
                /// <item><description><para>{ExtName}: The file extension. This is the output format specified in the transcoding template.</para>
                /// </description></item>
                /// <item><description><para>{DestMd5}: The MD5 hash of the transcoded output file.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <ol>
                /// <item><description><para>You must include both {MediaId} and {JobId} in this parameter.</para>
                /// </description></item>
                /// <item><description><para>The output bucket must be the same as the bucket where the media asset resides.</para>
                /// </description></item>
                /// </ol>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/{MediaId}/{JobId}.mp4</para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

                /// <summary>
                /// <para>The media object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>OSS: An OSS file.</para>
                /// </description></item>
                /// <item><description><para>Media: A media asset ID.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProcessConfig")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupProcessConfig ProcessConfig { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupProcessConfig : TeaModel {
                /// <summary>
                /// <para>The configuration for merging multiple inputs.</para>
                /// </summary>
                [NameInMap("CombineConfigs")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigCombineConfigs> CombineConfigs { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigCombineConfigs : TeaModel {
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
                    /// <para>The duration of the input stream. Default: The video duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20.0</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public double? Duration { get; set; }

                    /// <summary>
                    /// <para>The start time of the input stream. Default: 0.</para>
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
                    /// <para>0 or exclude</para>
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
                public SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption Encryption { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption : TeaModel {
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
                    /// <para>The encryption type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>PrivateEncryption: Alibaba Cloud proprietary cryptography.</para>
                    /// </description></item>
                    /// <item><description><para>HLSEncryption: HLS standard encryption.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PrivateEncryption</para>
                    /// </summary>
                    [NameInMap("EncryptType")]
                    [Validation(Required=false)]
                    public string EncryptType { get; set; }

                    /// <summary>
                    /// <para>The key service type for standard encryption. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>KMS</para>
                    /// </description></item>
                    /// <item><description><para>Base64</para>
                    /// </description></item>
                    /// </list>
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
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks : TeaModel {
                    /// <summary>
                    /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
                    /// </summary>
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
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
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

                /// <summary>
                /// <para>The subtitle burn-in configuration.</para>
                /// </summary>
                [NameInMap("Subtitles")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles : TeaModel {
                    /// <summary>
                    /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
                    /// </summary>
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
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
                        /// <para>The subtitle file format.</para>
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
                    /// <para>This parameter is required.</para>
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
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks : TeaModel {
                    /// <summary>
                    /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
                    /// </summary>
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                        /// <summary>
                        /// <para>Adjusts the font size based on the output video size. Valid values: true or false. Default: false.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Adaptive")]
                        [Validation(Required=false)]
                        public string Adaptive { get; set; }

                        /// <summary>
                        /// <para>The outline color. Default: Black. For more values, see BorderColor.</para>
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
                        /// <item><description><para>Valid values: (0, 4096]</para>
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
                        /// <para>Test watermark</para>
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
                    /// <para>This parameter is required.</para>
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
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Transcode")]
                [Validation(Required=false)]
                public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode Transcode { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode : TeaModel {
                    /// <summary>
                    /// <para>Parameters to overwrite. If you specify these, they replace the corresponding parameters in the template.</para>
                    /// </summary>
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                        /// <summary>
                        /// <para>The audio settings.</para>
                        /// </summary>
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                            /// <summary>
                            /// <para>The audio bitrate of the output file. Valid values: [8, 1000]. Unit: Kbps. Default value: 128.</para>
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
                            /// <para>The sample rate. Default value: 44100. Valid values: 22050, 32000, 44100, 48000, and 96000. Unit: Hz.</para>
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
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                                /// <para>The true peak volume.</para>
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                            /// <summary>
                            /// <para>The segment settings.</para>
                            /// </summary>
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
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
                            /// <para>Default value:</para>
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
                            /// <para>Specifies whether to check the audio bitrate. IsCheckAudioBitrate and IsCheckAudioBitrateFail are mutually exclusive. IsCheckAudioBitrateFail has higher priority.</para>
                            /// <list type="bullet">
                            /// <item><description><para>true: Check the bitrate. If the input audio bitrate is lower than the output setting, return a failure.</para>
                            /// </description></item>
                            /// <item><description><para>false: Do not check the bitrate.</para>
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
                            /// <para>Specifies whether to check the video resolution. IsCheckReso and IsCheckResoFail are mutually exclusive. IsCheckResoFail has higher priority.</para>
                            /// <list type="bullet">
                            /// <item><description><para>true: Check the resolution. If the input video resolution (width or height) is smaller than the output setting, transcode at the input resolution.</para>
                            /// </description></item>
                            /// <item><description><para>false: Do not check the resolution.</para>
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
                            /// <para>Specifies whether to check the video resolution. IsCheckReso and IsCheckResoFail are mutually exclusive. IsCheckResoFail has higher priority.</para>
                            /// <list type="bullet">
                            /// <item><description><para>true: Check the resolution. If the input video resolution (width or height) is smaller than the output setting, return a failure.</para>
                            /// </description></item>
                            /// <item><description><para>false: Do not check the resolution.</para>
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
                            /// <para>Specifies whether to check the video bitrate. IsCheckVideoBitrate and IsCheckVideoBitrateFail are mutually exclusive. IsCheckVideoBitrateFail has higher priority.</para>
                            /// <list type="bullet">
                            /// <item><description><para>true: Check the bitrate. If the input video bitrate is lower than the output setting, transcode at the input bitrate.</para>
                            /// </description></item>
                            /// <item><description><para>false: Do not check the bitrate.</para>
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
                            /// <para>Specifies whether to check the video bitrate. IsCheckVideoBitrate and IsCheckVideoBitrateFail are mutually exclusive. IsCheckVideoBitrateFail has higher priority.</para>
                            /// <list type="bullet">
                            /// <item><description><para>true: Check the bitrate. If the input video bitrate is lower than the output setting, return a failure.</para>
                            /// </description></item>
                            /// <item><description><para>false: Do not check the bitrate.</para>
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
                            /// <item><description><para>onepass: Used for adaptive bitrate (ABR) streaming. Encoding is faster than twopass.</para>
                            /// </description></item>
                            /// <item><description><para>twopass: Used for variable bitrate (VBR) streaming. Encoding is slower than onepass.</para>
                            /// </description></item>
                            /// <item><description><para>CBR: Constant bitrate mode.</para>
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
                        /// <para>The video settings.</para>
                        /// </summary>
                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
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
                            /// <para>The average video bitrate. Valid values: [10, 50000]. Unit: Kbps.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3000</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <para>The buffer size. Valid values: [1000, 128000]. Default value: 6000. Unit: Kb.</para>
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
                            /// <para>The constant rate factor (CRF), which controls the trade-off between quality and bitrate. Valid values: [0, 51]. Default values: 23 for H.264 and 26 for H.265.</para>
                            /// <remarks>
                            /// <para>If you set Crf, the Bitrate setting is ignored.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>23</para>
                            /// </summary>
                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }

                            /// <summary>
                            /// <para>The video cropping method. Two options are available:</para>
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
                            /// <para>The frame rate. Valid values: (0, 60]. Default value: The frame rate of the input file.</para>
                            /// <remarks>
                            /// <para>If the frame rate of the input file exceeds 60, the system uses 60.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>25</para>
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// <para>The maximum number of frames between keyframes. Valid values: [1, 1080000]. Default value: 250.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>250</para>
                            /// </summary>
                            [NameInMap("Gop")]
                            [Validation(Required=false)]
                            public string Gop { get; set; }

                            /// <summary>
                            /// <para>The height. Valid values: [128, 4096]. Unit: px. Default value: The original video height.</para>
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
                            /// <para>The padding configuration for black bars. Format: width:height:left:top. Example: 1280:800:0:140</para>
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
                            /// <para>The width. Valid values: [128, 4096]. Unit: px. Default value: The original video width.</para>
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
                    /// <para>This parameter is required.</para>
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
        /// <para>The job scheduling information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitTranscodeJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitTranscodeJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <para>The MPS queue ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The job priority. A larger number indicates a higher priority. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>Custom settings in JSON format. The length is limited to 512 bytes. Supports <a href="https://help.aliyun.com/document_detail/451631.html">custom webhook address configuration</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
