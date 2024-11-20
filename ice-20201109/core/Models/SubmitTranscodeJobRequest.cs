// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The input group of the job. An input of a single file indicates a transcoding job. An input of multiple files indicates an audio and video stream merge job.</para>
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
            /// <para>The URL of the input stream.</para>
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
            /// </list>
            /// <remarks>
            /// <para> Before you use the OSS bucket in the URL, you must add the bucket on the <a href="https://help.aliyun.com/document_detail/440592.html">Storage Management</a> page of the Intelligent Media Services (IMS) console.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
            /// <para>The type of the media object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: an Object Storage Service (OSS) object.</description></item>
            /// <item><description>Media: a media asset.</description></item>
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
        /// <para>The output group of the job.</para>
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
            /// <para>The output file configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupOutput Output { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupOutput : TeaModel {
                /// <summary>
                /// <para>The media object.</para>
                /// <list type="bullet">
                /// <item><description>If Type is set to OSS, set this parameter to the URL of an OSS object. Both the OSS and HTTP protocols are supported.</description></item>
                /// </list>
                /// <remarks>
                /// <para> Before you use the OSS bucket in the URL, you must add the bucket on the <a href="https://help.aliyun.com/document_detail/440592.html">Storage Management</a> page of the IMS console.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>If Type is set to Media, set this parameter to the ID of a media asset.</description></item>
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
                /// <para>The multi-input stream merge configuration.</para>
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
                public SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption Encryption { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption : TeaModel {
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
                    /// <para>The address of the decryption service for HLS encryption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://sample.com/path?CipherText=MTYi00NDU0LTg5O">https://sample.com/path?CipherText=MTYi00NDU0LTg5O</a>****</para>
                    /// </summary>
                    [NameInMap("DecryptKeyUri")]
                    [Validation(Required=false)]
                    public string DecryptKeyUri { get; set; }

                    /// <summary>
                    /// <para>Specifies the encryption type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PrivateEncryption: Alibaba Cloud proprietary cryptography</description></item>
                    /// <item><description>HLSEncryption: HTTP Live Streaming (HLS) encryption</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PrivateEncryption</para>
                    /// </summary>
                    [NameInMap("EncryptType")]
                    [Validation(Required=false)]
                    public string EncryptType { get; set; }

                    /// <summary>
                    /// <para>The key service type for HLS encryption. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>KMS</description></item>
                    /// <item><description>Base64</description></item>
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
                /// <para>The watermark configuration of an image.</para>
                /// </summary>
                [NameInMap("ImageWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks : TeaModel {
                    /// <summary>
                    /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                    /// </summary>
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
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
                /// <para>The subtitle configuration.</para>
                /// </summary>
                [NameInMap("Subtitles")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles : TeaModel {
                    /// <summary>
                    /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
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
                /// <para>The configurations of the text watermark.</para>
                /// </summary>
                [NameInMap("TextWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks : TeaModel {
                    /// <summary>
                    /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
                    /// </summary>
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
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
                    /// <para>The parameters that are used to overwrite the corresponding parameters of the template.</para>
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
                            /// <para>The audio bitrate of the output file. Valid values: [8,1000]. Unit: Kbit/s. Default value: 128.</para>
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
                            /// <para>The sampling rate. Valid values: 22050, 32000, 44100, 48000, and 96000. Default value: 44100. Unit: Hz.</para>
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
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                        /// <para>The encapsulation settings.</para>
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
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
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
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
                            /// <para>The average video bitrate. Valid values: [10,50000]. Unit: Kbit/s.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3000</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <para>The buffer size. Valid values: [1000,128000]. Default value: 6000. Unit: KB.</para>
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
                            /// <para>The constant rate factor (CRF). Valid values: [0,51]. Default value: 23 if the encoding format is H.264, or 26 if the encoding format is H.265.</para>
                            /// <remarks>
                            /// <para> If this parameter is specified, the setting of the bitrate becomes invalid.</para>
                            /// </remarks>
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
                            /// <para>The frame rate. Valid values:(0,60]. Default value: the frame rate of the input file.</para>
                            /// <remarks>
                            /// <para> The value is 60 if the frame rate of the input file exceeds 60.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>25</para>
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// <para>The maximum number of frames between keyframes. Valid values: [1,1080000]. Default value: 250.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>250</para>
                            /// </summary>
                            [NameInMap("Gop")]
                            [Validation(Required=false)]
                            public string Gop { get; set; }

                            /// <summary>
                            /// <para>The height of the video. Valid values: [128,4096]. Unit: pixels. Default value: the original height of the video.</para>
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
                            /// <para>The maximum bitrate of the video. Valid values: [10,50000]. Unit: Kbit/s.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>9000</para>
                            /// </summary>
                            [NameInMap("Maxrate")]
                            [Validation(Required=false)]
                            public string Maxrate { get; set; }

                            /// <summary>
                            /// <para>The black bars added to the video. Format: width:height:left:top. Example: 1280:800:0:140.</para>
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
                            /// <para>The width of the video. Valid values: [128,4096]. Unit: pixels. Default value: the original width of the video.</para>
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
        /// <para>The scheduling information about the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitTranscodeJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitTranscodeJobRequestScheduleConfig : TeaModel {
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
        /// <para>The custom settings. The value must be in the JSON format and can be up to 512 bytes in length. You can specify a <a href="https://help.aliyun.com/document_detail/451631.html">custom callback URL</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
