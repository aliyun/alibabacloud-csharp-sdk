// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTranscodeJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>9EDC30DC-0050-5459-B788-F761B2BE359B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>TranscodeParentJobWithSubJobDTO</para>
        /// </summary>
        [NameInMap("TranscodeParentJob")]
        [Validation(Required=false)]
        public GetTranscodeJobResponseBodyTranscodeParentJob TranscodeParentJob { get; set; }
        public class GetTranscodeJobResponseBodyTranscodeParentJob : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("InputGroup")]
            [Validation(Required=false)]
            public List<GetTranscodeJobResponseBodyTranscodeParentJobInputGroup> InputGroup { get; set; }
            public class GetTranscodeJobResponseBodyTranscodeParentJobInputGroup : TeaModel {
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("JobCount")]
            [Validation(Required=false)]
            public int? JobCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>transcode-job</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OutputGroup")]
            [Validation(Required=false)]
            public List<GetTranscodeJobResponseBodyTranscodeParentJobOutputGroup> OutputGroup { get; set; }
            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroup : TeaModel {
                [NameInMap("Output")]
                [Validation(Required=false)]
                public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput Output { get; set; }
                public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupOutput : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OSS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("ProcessConfig")]
                [Validation(Required=false)]
                public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig ProcessConfig { get; set; }
                public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfig : TeaModel {
                    [NameInMap("CombineConfigs")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigCombineConfigs> CombineConfigs { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigCombineConfigs : TeaModel {
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
                    public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigEncryption Encryption { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigEncryption : TeaModel {
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
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarks : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
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
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitles : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>UTF-8</para>
                            /// </summary>
                            [NameInMap("CharEnc")]
                            [Validation(Required=false)]
                            public string CharEnc { get; set; }

                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
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
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarks : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
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
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    [NameInMap("Transcode")]
                    [Validation(Required=false)]
                    public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscode Transcode { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscode : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
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
                                public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
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
            /// <para>8b2198504dd340b7b3c9842a74fc9baa</para>
            /// </summary>
            [NameInMap("ParentJobId")]
            [Validation(Required=false)]
            public string ParentJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public GetTranscodeJobResponseBodyTranscodeParentJobScheduleConfig ScheduleConfig { get; set; }
            public class GetTranscodeJobResponseBodyTranscodeParentJobScheduleConfig : TeaModel {
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
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-12T08:49:41Z</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            [NameInMap("TranscodeJobList")]
            [Validation(Required=false)]
            public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList> TranscodeJobList { get; set; }
            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-12T08:49:41Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-12T08:49:41Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("InputGroup")]
                [Validation(Required=false)]
                public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup> InputGroup { get; set; }
                public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListInputGroup : TeaModel {
                    [NameInMap("InputUrl")]
                    [Validation(Required=false)]
                    public string InputUrl { get; set; }

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
                /// <para>7d6a7e0d4db2457a8d45ff5d43e1bf0a</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("JobIndex")]
                [Validation(Required=false)]
                public int? JobIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>transcode-job</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OutFileMeta")]
                [Validation(Required=false)]
                public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta OutFileMeta { get; set; }
                public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMeta : TeaModel {
                    [NameInMap("AudioStreamInfoList")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaAudioStreamInfoList> AudioStreamInfoList { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaAudioStreamInfoList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.f</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>stereo</para>
                        /// </summary>
                        [NameInMap("ChannelLayout")]
                        [Validation(Required=false)]
                        public string ChannelLayout { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public string Channels { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>AAC (Advanced Audio Coding)</para>
                        /// </summary>
                        [NameInMap("CodecLongName")]
                        [Validation(Required=false)]
                        public string CodecLongName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>aac</para>
                        /// </summary>
                        [NameInMap("CodecName")]
                        [Validation(Required=false)]
                        public string CodecName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0x000f</para>
                        /// </summary>
                        [NameInMap("CodecTag")]
                        [Validation(Required=false)]
                        public string CodecTag { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[15][0][0][0]</para>
                        /// </summary>
                        [NameInMap("CodecTagString")]
                        [Validation(Required=false)]
                        public string CodecTagString { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1/44100</para>
                        /// </summary>
                        [NameInMap("CodecTimeBase")]
                        [Validation(Required=false)]
                        public string CodecTimeBase { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>403.039989</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn</para>
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>fltp</para>
                        /// </summary>
                        [NameInMap("SampleFmt")]
                        [Validation(Required=false)]
                        public string SampleFmt { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>44100</para>
                        /// </summary>
                        [NameInMap("SampleRate")]
                        [Validation(Required=false)]
                        public string SampleRate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1.473556</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1/90000</para>
                        /// </summary>
                        [NameInMap("Timebase")]
                        [Validation(Required=false)]
                        public string Timebase { get; set; }

                    }

                    [NameInMap("FileBasicInfo")]
                    [Validation(Required=false)]
                    public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaFileBasicInfo FileBasicInfo { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaFileBasicInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>888.563</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>403.039999</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>file.m3u8</para>
                        /// </summary>
                        [NameInMap("FileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>31737</para>
                        /// </summary>
                        [NameInMap("FileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Normal</para>
                        /// </summary>
                        [NameInMap("FileStatus")]
                        [Validation(Required=false)]
                        public string FileStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>source_file</para>
                        /// </summary>
                        [NameInMap("FileType")]
                        [Validation(Required=false)]
                        public string FileType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8">http://bucket.oss-cn-shanghai.aliyuncs.com/path/to/file.m3u8</a></para>
                        /// </summary>
                        [NameInMap("FileUrl")]
                        [Validation(Required=false)]
                        public string FileUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>hls,applehttp</para>
                        /// </summary>
                        [NameInMap("FormatName")]
                        [Validation(Required=false)]
                        public string FormatName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>478</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>486c2890096871edba6f81848c016303</para>
                        /// </summary>
                        [NameInMap("MediaId")]
                        [Validation(Required=false)]
                        public string MediaId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-shanghai</para>
                        /// </summary>
                        [NameInMap("Region")]
                        [Validation(Required=false)]
                        public string Region { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>848</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    [NameInMap("VideoStreamInfoList")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaVideoStreamInfoList> VideoStreamInfoList { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutFileMetaVideoStreamInfoList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>25.0</para>
                        /// </summary>
                        [NameInMap("Avg_fps")]
                        [Validation(Required=false)]
                        public string AvgFps { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>888.563</para>
                        /// </summary>
                        [NameInMap("Bit_rate")]
                        [Validation(Required=false)]
                        public string BitRate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
                        /// </summary>
                        [NameInMap("Codec_long_name")]
                        [Validation(Required=false)]
                        public string CodecLongName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>h264</para>
                        /// </summary>
                        [NameInMap("Codec_name")]
                        [Validation(Required=false)]
                        public string CodecName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0x001b</para>
                        /// </summary>
                        [NameInMap("Codec_tag")]
                        [Validation(Required=false)]
                        public string CodecTag { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[27][0][0][0]</para>
                        /// </summary>
                        [NameInMap("Codec_tag_string")]
                        [Validation(Required=false)]
                        public string CodecTagString { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1/50</para>
                        /// </summary>
                        [NameInMap("Codec_time_base")]
                        [Validation(Required=false)]
                        public string CodecTimeBase { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>16:9</para>
                        /// </summary>
                        [NameInMap("Dar")]
                        [Validation(Required=false)]
                        public string Dar { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>403.039989</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>25.0</para>
                        /// </summary>
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Has_b_frames")]
                        [Validation(Required=false)]
                        public string HasBFrames { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>478</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public string Index { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn</para>
                        /// </summary>
                        [NameInMap("Lang")]
                        [Validation(Required=false)]
                        public string Lang { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>31</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10040</para>
                        /// </summary>
                        [NameInMap("NumFrames")]
                        [Validation(Required=false)]
                        public string NumFrames { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>yuv420p</para>
                        /// </summary>
                        [NameInMap("PixFmt")]
                        [Validation(Required=false)]
                        public string PixFmt { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>High</para>
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Rotate")]
                        [Validation(Required=false)]
                        public string Rotate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>478:477</para>
                        /// </summary>
                        [NameInMap("Sar")]
                        [Validation(Required=false)]
                        public string Sar { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1.473556</para>
                        /// </summary>
                        [NameInMap("Start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1/90000</para>
                        /// </summary>
                        [NameInMap("Time_base")]
                        [Validation(Required=false)]
                        public string TimeBase { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>848</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }

                [NameInMap("Output")]
                [Validation(Required=false)]
                public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput Output { get; set; }
                public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListOutput : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oss://bucket/path/to/video.mp4</para>
                    /// </summary>
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

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
                /// <para>8b2198504dd340b7b3c9842a74fc9baa</para>
                /// </summary>
                [NameInMap("ParentJobId")]
                [Validation(Required=false)]
                public string ParentJobId { get; set; }

                [NameInMap("ProcessConfig")]
                [Validation(Required=false)]
                public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig ProcessConfig { get; set; }
                public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfig : TeaModel {
                    [NameInMap("CombineConfigs")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigCombineConfigs> CombineConfigs { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigCombineConfigs : TeaModel {
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
                    public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigEncryption Encryption { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigEncryption : TeaModel {
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
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarks : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParams : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
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
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    [NameInMap("IsInheritTags")]
                    [Validation(Required=false)]
                    public bool? IsInheritTags { get; set; }

                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles> Subtitles { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitles : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParams : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>UTF-8</para>
                            /// </summary>
                            [NameInMap("CharEnc")]
                            [Validation(Required=false)]
                            public string CharEnc { get; set; }

                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
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
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarks : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTextWatermarksOverwriteParams : TeaModel {
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
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                    [NameInMap("Transcode")]
                    [Validation(Required=false)]
                    public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscode Transcode { get; set; }
                    public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscode : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParams : TeaModel {
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
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
                                public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
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

                            [NameInMap("Tags")]
                            [Validation(Required=false)]
                            public Dictionary<string, string> Tags { get; set; }

                            [NameInMap("TransConfig")]
                            [Validation(Required=false)]
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
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
                            public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
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
                        /// <b>Example:</b>
                        /// <para>9547c6ad97cb4f2aaa29683ebd18d410</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>31E30781-9495-5E2D-A84D-759B0A01E262</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ScheduleConfig")]
                [Validation(Required=false)]
                public GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig ScheduleConfig { get; set; }
                public class GetTranscodeJobResponseBodyTranscodeParentJobTranscodeJobListScheduleConfig : TeaModel {
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
                /// <para>Init</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("SubmitResultJson")]
                [Validation(Required=false)]
                public Dictionary<string, object> SubmitResultJson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-12T08:49:41Z</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user-data</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user-data</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
