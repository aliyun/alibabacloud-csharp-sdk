// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateVideoPlaylistRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("MasterURI")]
        [Validation(Required=false)]
        public string MasterURI { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceDuration")]
        [Validation(Required=false)]
        public float? SourceDuration { get; set; }

        [NameInMap("SourceStartTime")]
        [Validation(Required=false)]
        public float? SourceStartTime { get; set; }

        [NameInMap("SourceSubtitles")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestSourceSubtitles> SourceSubtitles { get; set; }
        public class GenerateVideoPlaylistRequestSourceSubtitles : TeaModel {
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<GenerateVideoPlaylistRequestTargets> Targets { get; set; }
        public class GenerateVideoPlaylistRequestTargets : TeaModel {
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public GenerateVideoPlaylistRequestTargetsAudio Audio { get; set; }
            public class GenerateVideoPlaylistRequestTargetsAudio : TeaModel {
                [NameInMap("DisableAudio")]
                [Validation(Required=false)]
                public bool? DisableAudio { get; set; }

                [NameInMap("FilterAudio")]
                [Validation(Required=false)]
                public GenerateVideoPlaylistRequestTargetsAudioFilterAudio FilterAudio { get; set; }
                public class GenerateVideoPlaylistRequestTargetsAudioFilterAudio : TeaModel {
                    [NameInMap("Mixing")]
                    [Validation(Required=false)]
                    public bool? Mixing { get; set; }

                }

                [NameInMap("TranscodeAudio")]
                [Validation(Required=false)]
                public GenerateVideoPlaylistRequestTargetsAudioTranscodeAudio TranscodeAudio { get; set; }
                public class GenerateVideoPlaylistRequestTargetsAudioTranscodeAudio : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public int? Bitrate { get; set; }

                    [NameInMap("BitrateOption")]
                    [Validation(Required=false)]
                    public string BitrateOption { get; set; }

                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public int? Channel { get; set; }

                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public int? Quality { get; set; }

                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public int? SampleRate { get; set; }

                    [NameInMap("SampleRateOption")]
                    [Validation(Required=false)]
                    public string SampleRateOption { get; set; }

                }

            }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("InitialSegments")]
            [Validation(Required=false)]
            public List<float?> InitialSegments { get; set; }

            [NameInMap("InitialTranscode")]
            [Validation(Required=false)]
            public float? InitialTranscode { get; set; }

            [NameInMap("PresetId")]
            [Validation(Required=false)]
            public PresetReference PresetId { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public GenerateVideoPlaylistRequestTargetsSubtitle Subtitle { get; set; }
            public class GenerateVideoPlaylistRequestTargetsSubtitle : TeaModel {
                [NameInMap("DisableSubtitle")]
                [Validation(Required=false)]
                public bool? DisableSubtitle { get; set; }

                [NameInMap("ExtractSubtitle")]
                [Validation(Required=false)]
                public GenerateVideoPlaylistRequestTargetsSubtitleExtractSubtitle ExtractSubtitle { get; set; }
                public class GenerateVideoPlaylistRequestTargetsSubtitleExtractSubtitle : TeaModel {
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("URI")]
                    [Validation(Required=false)]
                    public string URI { get; set; }

                }

            }

            [NameInMap("TranscodeAhead")]
            [Validation(Required=false)]
            public int? TranscodeAhead { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            [NameInMap("Video")]
            [Validation(Required=false)]
            public GenerateVideoPlaylistRequestTargetsVideo Video { get; set; }
            public class GenerateVideoPlaylistRequestTargetsVideo : TeaModel {
                [NameInMap("DisableVideo")]
                [Validation(Required=false)]
                public bool? DisableVideo { get; set; }

                [NameInMap("FilterVideo")]
                [Validation(Required=false)]
                public GenerateVideoPlaylistRequestTargetsVideoFilterVideo FilterVideo { get; set; }
                public class GenerateVideoPlaylistRequestTargetsVideoFilterVideo : TeaModel {
                    [NameInMap("Delogos")]
                    [Validation(Required=false)]
                    public List<GenerateVideoPlaylistRequestTargetsVideoFilterVideoDelogos> Delogos { get; set; }
                    public class GenerateVideoPlaylistRequestTargetsVideoFilterVideoDelogos : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public float? Duration { get; set; }

                        [NameInMap("Dx")]
                        [Validation(Required=false)]
                        public float? Dx { get; set; }

                        [NameInMap("Dy")]
                        [Validation(Required=false)]
                        public float? Dy { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        [NameInMap("ReferPos")]
                        [Validation(Required=false)]
                        public string ReferPos { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public float? StartTime { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                    }

                    [NameInMap("Watermarks")]
                    [Validation(Required=false)]
                    public List<GenerateVideoPlaylistRequestTargetsVideoFilterVideoWatermarks> Watermarks { get; set; }
                    public class GenerateVideoPlaylistRequestTargetsVideoFilterVideoWatermarks : TeaModel {
                        [NameInMap("BoardWidth")]
                        [Validation(Required=false)]
                        public int? BoardWidth { get; set; }

                        [NameInMap("BorderColor")]
                        [Validation(Required=false)]
                        public string BorderColor { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public float? Duration { get; set; }

                        [NameInMap("Dx")]
                        [Validation(Required=false)]
                        public float? Dx { get; set; }

                        [NameInMap("Dy")]
                        [Validation(Required=false)]
                        public float? Dy { get; set; }

                        [NameInMap("FontApha")]
                        [Validation(Required=false)]
                        public float? FontApha { get; set; }

                        [NameInMap("FontColor")]
                        [Validation(Required=false)]
                        public string FontColor { get; set; }

                        [NameInMap("FontName")]
                        [Validation(Required=false)]
                        public string FontName { get; set; }

                        [NameInMap("FontSize")]
                        [Validation(Required=false)]
                        public int? FontSize { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        [NameInMap("ReferPos")]
                        [Validation(Required=false)]
                        public string ReferPos { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public float? StartTime { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("URI")]
                        [Validation(Required=false)]
                        public string URI { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                    }

                }

                [NameInMap("TranscodeVideo")]
                [Validation(Required=false)]
                public GenerateVideoPlaylistRequestTargetsVideoTranscodeVideo TranscodeVideo { get; set; }
                public class GenerateVideoPlaylistRequestTargetsVideoTranscodeVideo : TeaModel {
                    [NameInMap("AdaptiveResolutionDirection")]
                    [Validation(Required=false)]
                    public bool? AdaptiveResolutionDirection { get; set; }

                    [NameInMap("BFrames")]
                    [Validation(Required=false)]
                    public int? BFrames { get; set; }

                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public int? Bitrate { get; set; }

                    [NameInMap("BitrateOption")]
                    [Validation(Required=false)]
                    public string BitrateOption { get; set; }

                    [NameInMap("BufferSize")]
                    [Validation(Required=false)]
                    public int? BufferSize { get; set; }

                    [NameInMap("CRF")]
                    [Validation(Required=false)]
                    public float? CRF { get; set; }

                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    [NameInMap("FrameRate")]
                    [Validation(Required=false)]
                    public float? FrameRate { get; set; }

                    [NameInMap("FrameRateOption")]
                    [Validation(Required=false)]
                    public string FrameRateOption { get; set; }

                    [NameInMap("GOPSize")]
                    [Validation(Required=false)]
                    public int? GOPSize { get; set; }

                    [NameInMap("MaxBitrate")]
                    [Validation(Required=false)]
                    public int? MaxBitrate { get; set; }

                    [NameInMap("PixelFormat")]
                    [Validation(Required=false)]
                    public string PixelFormat { get; set; }

                    [NameInMap("Refs")]
                    [Validation(Required=false)]
                    public int? Refs { get; set; }

                    [NameInMap("Resolution")]
                    [Validation(Required=false)]
                    public string Resolution { get; set; }

                    [NameInMap("ResolutionOption")]
                    [Validation(Required=false)]
                    public string ResolutionOption { get; set; }

                    [NameInMap("Rotation")]
                    [Validation(Required=false)]
                    public int? Rotation { get; set; }

                    [NameInMap("ScaleType")]
                    [Validation(Required=false)]
                    public string ScaleType { get; set; }

                }

            }

        }

    }

}
