// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestInputGroup> InputGroup { get; set; }
        public class SubmitTranscodeJobRequestInputGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://bucket/path/to/video.mp4</para>
            /// </summary>
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/path/to/video.mp4</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestOutputGroup> OutputGroup { get; set; }
        public class SubmitTranscodeJobRequestOutputGroup : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupOutput Output { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupOutput : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/video.mp4</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://bucket/path/to/{MediaId}/{JobId}.mp4</para>
                /// </summary>
                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProcessConfig")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupProcessConfig ProcessConfig { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupProcessConfig : TeaModel {
                [NameInMap("CombineConfigs")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigCombineConfigs> CombineConfigs { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigCombineConfigs : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 或 exclude</para>
                    /// </summary>
                    [NameInMap("AudioIndex")]
                    [Validation(Required=false)]
                    public string AudioIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20.0</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public double? Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public double? Start { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 或 exclude</para>
                    /// </summary>
                    [NameInMap("VideoIndex")]
                    [Validation(Required=false)]
                    public string VideoIndex { get; set; }

                }

                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption Encryption { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MTYi00NDU0LTg5O****</para>
                    /// </summary>
                    [NameInMap("CipherText")]
                    [Validation(Required=false)]
                    public string CipherText { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://sample.com/path?CipherText=MTYi00NDU0LTg5O">https://sample.com/path?CipherText=MTYi00NDU0LTg5O</a>****</para>
                    /// </summary>
                    [NameInMap("DecryptKeyUri")]
                    [Validation(Required=false)]
                    public string DecryptKeyUri { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PrivateEncryption</para>
                    /// </summary>
                    [NameInMap("EncryptType")]
                    [Validation(Required=false)]
                    public string EncryptType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>KMS</para>
                    /// </summary>
                    [NameInMap("KeyServiceType")]
                    [Validation(Required=false)]
                    public string KeyServiceType { get; set; }

                }

                [NameInMap("ImageWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Dx")]
                        [Validation(Required=false)]
                        public string Dx { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Dy")]
                        [Validation(Required=false)]
                        public string Dy { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>oss://bucket/path/to/video.mp4</para>
                            /// </summary>
                            [NameInMap("Media")]
                            [Validation(Required=false)]
                            public string Media { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>OSS</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>32</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TopLeft</para>
                        /// </summary>
                        [NameInMap("ReferPos")]
                        [Validation(Required=false)]
                        public string ReferPos { get; set; }

                        [NameInMap("Timeline")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>ToEND</para>
                            /// </summary>
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>00:00:05</para>
                            /// </summary>
                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>32</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

                [NameInMap("Subtitles")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>UTF-8</para>
                        /// </summary>
                        [NameInMap("CharEnc")]
                        [Validation(Required=false)]
                        public string CharEnc { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>oss://bucket/path/to/video.mp4</para>
                            /// </summary>
                            [NameInMap("Media")]
                            [Validation(Required=false)]
                            public string Media { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>OSS</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vtt</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

                [NameInMap("TextWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Adaptive")]
                        [Validation(Required=false)]
                        public string Adaptive { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>#006400</para>
                        /// </summary>
                        [NameInMap("BorderColor")]
                        [Validation(Required=false)]
                        public string BorderColor { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BorderWidth")]
                        [Validation(Required=false)]
                        public int? BorderWidth { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>测试水印</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1.0</para>
                        /// </summary>
                        [NameInMap("FontAlpha")]
                        [Validation(Required=false)]
                        public string FontAlpha { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>#006400</para>
                        /// </summary>
                        [NameInMap("FontColor")]
                        [Validation(Required=false)]
                        public string FontColor { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>SimSun</para>
                        /// </summary>
                        [NameInMap("FontName")]
                        [Validation(Required=false)]
                        public string FontName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>16</para>
                        /// </summary>
                        [NameInMap("FontSize")]
                        [Validation(Required=false)]
                        public int? FontSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public string Left { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public string Top { get; set; }

                    }

                    /// <summary>
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
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Transcode")]
                [Validation(Required=false)]
                public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode Transcode { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>128</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>AAC</para>
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>aac_low</para>
                            /// </summary>
                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>44100</para>
                            /// </summary>
                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            [NameInMap("Volume")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>-6</para>
                                /// </summary>
                                [NameInMap("IntegratedLoudnessTarget")]
                                [Validation(Required=false)]
                                public string IntegratedLoudnessTarget { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>8</para>
                                /// </summary>
                                [NameInMap("LoudnessRangeTarget")]
                                [Validation(Required=false)]
                                public string LoudnessRangeTarget { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>auto</para>
                                /// </summary>
                                [NameInMap("Method")]
                                [Validation(Required=false)]
                                public string Method { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>-1</para>
                                /// </summary>
                                [NameInMap("TruePeak")]
                                [Validation(Required=false)]
                                public string TruePeak { get; set; }

                            }

                        }

                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>mp4</para>
                            /// </summary>
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }

                        [NameInMap("MuxConfig")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>2,3</para>
                                /// </summary>
                                [NameInMap("ForceSegTime")]
                                [Validation(Required=false)]
                                public string ForceSegTime { get; set; }

                            }

                        }

                        [NameInMap("TransConfig")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
                            [NameInMap("AdjDarMethod")]
                            [Validation(Required=false)]
                            public string AdjDarMethod { get; set; }

                            [NameInMap("IsCheckAudioBitrate")]
                            [Validation(Required=false)]
                            public string IsCheckAudioBitrate { get; set; }

                            [NameInMap("IsCheckAudioBitrateFail")]
                            [Validation(Required=false)]
                            public string IsCheckAudioBitrateFail { get; set; }

                            [NameInMap("IsCheckReso")]
                            [Validation(Required=false)]
                            public string IsCheckReso { get; set; }

                            [NameInMap("IsCheckResoFail")]
                            [Validation(Required=false)]
                            public string IsCheckResoFail { get; set; }

                            [NameInMap("IsCheckVideoBitrate")]
                            [Validation(Required=false)]
                            public string IsCheckVideoBitrate { get; set; }

                            [NameInMap("IsCheckVideoBitrateFail")]
                            [Validation(Required=false)]
                            public string IsCheckVideoBitrateFail { get; set; }

                            [NameInMap("TransMode")]
                            [Validation(Required=false)]
                            public string TransMode { get; set; }

                        }

                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>6000</para>
                            /// </summary>
                            [NameInMap("AbrMax")]
                            [Validation(Required=false)]
                            public string AbrMax { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3000</para>
                            /// </summary>
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>6000</para>
                            /// </summary>
                            [NameInMap("Bufsize")]
                            [Validation(Required=false)]
                            public string Bufsize { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>H.264</para>
                            /// </summary>
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>23</para>
                            /// </summary>
                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1280:800:0:140</para>
                            /// </summary>
                            [NameInMap("Crop")]
                            [Validation(Required=false)]
                            public string Crop { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>25</para>
                            /// </summary>
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>250</para>
                            /// </summary>
                            [NameInMap("Gop")]
                            [Validation(Required=false)]
                            public string Gop { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1080</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("LongShortMode")]
                            [Validation(Required=false)]
                            public string LongShortMode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>9000</para>
                            /// </summary>
                            [NameInMap("Maxrate")]
                            [Validation(Required=false)]
                            public string Maxrate { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1280:800:0:140</para>
                            /// </summary>
                            [NameInMap("Pad")]
                            [Validation(Required=false)]
                            public string Pad { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>yuv420p</para>
                            /// </summary>
                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>medium</para>
                            /// </summary>
                            [NameInMap("Preset")]
                            [Validation(Required=false)]
                            public string Preset { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Main</para>
                            /// </summary>
                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>false</para>
                            /// </summary>
                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>progressive</para>
                            /// </summary>
                            [NameInMap("ScanMode")]
                            [Validation(Required=false)]
                            public string ScanMode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1920</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                    }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>job-name</para>
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitTranscodeJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitTranscodeJobRequestScheduleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>e37ebee5d98b4781897f6086e89f9c56</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user-data</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
