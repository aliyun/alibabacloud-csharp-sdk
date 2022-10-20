// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetVideoPlaylistRequest : TeaModel {
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
        public List<GetVideoPlaylistRequestSourceSubtitles> SourceSubtitles { get; set; }
        public class GetVideoPlaylistRequestSourceSubtitles : TeaModel {
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
        public List<GetVideoPlaylistRequestTargets> Targets { get; set; }
        public class GetVideoPlaylistRequestTargets : TeaModel {
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public GetVideoPlaylistRequestTargetsAudio Audio { get; set; }
            public class GetVideoPlaylistRequestTargetsAudio : TeaModel {
                [NameInMap("DisableAudio")]
                [Validation(Required=false)]
                public bool? DisableAudio { get; set; }

                [NameInMap("FilterAudio")]
                [Validation(Required=false)]
                public GetVideoPlaylistRequestTargetsAudioFilterAudio FilterAudio { get; set; }
                public class GetVideoPlaylistRequestTargetsAudioFilterAudio : TeaModel {
                    [NameInMap("Mixing")]
                    [Validation(Required=false)]
                    public bool? Mixing { get; set; }

                }

                [NameInMap("TranscodeAudio")]
                [Validation(Required=false)]
                public GetVideoPlaylistRequestTargetsAudioTranscodeAudio TranscodeAudio { get; set; }
                public class GetVideoPlaylistRequestTargetsAudioTranscodeAudio : TeaModel {
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
            public GetVideoPlaylistRequestTargetsSubtitle Subtitle { get; set; }
            public class GetVideoPlaylistRequestTargetsSubtitle : TeaModel {
                [NameInMap("DisableSubtitle")]
                [Validation(Required=false)]
                public bool? DisableSubtitle { get; set; }

                [NameInMap("ExtractSubtitle")]
                [Validation(Required=false)]
                public GetVideoPlaylistRequestTargetsSubtitleExtractSubtitle ExtractSubtitle { get; set; }
                public class GetVideoPlaylistRequestTargetsSubtitleExtractSubtitle : TeaModel {
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
            public GetVideoPlaylistRequestTargetsVideo Video { get; set; }
            public class GetVideoPlaylistRequestTargetsVideo : TeaModel {
                [NameInMap("DisableVideo")]
                [Validation(Required=false)]
                public bool? DisableVideo { get; set; }

                [NameInMap("FilterVideo")]
                [Validation(Required=false)]
                public GetVideoPlaylistRequestTargetsVideoFilterVideo FilterVideo { get; set; }
                public class GetVideoPlaylistRequestTargetsVideoFilterVideo : TeaModel {
                    [NameInMap("Delogos")]
                    [Validation(Required=false)]
                    public List<GetVideoPlaylistRequestTargetsVideoFilterVideoDelogos> Delogos { get; set; }
                    public class GetVideoPlaylistRequestTargetsVideoFilterVideoDelogos : TeaModel {
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
                    public List<GetVideoPlaylistRequestTargetsVideoFilterVideoWatermarks> Watermarks { get; set; }
                    public class GetVideoPlaylistRequestTargetsVideoFilterVideoWatermarks : TeaModel {
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
                public GetVideoPlaylistRequestTargetsVideoTranscodeVideo TranscodeVideo { get; set; }
                public class GetVideoPlaylistRequestTargetsVideoTranscodeVideo : TeaModel {
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
