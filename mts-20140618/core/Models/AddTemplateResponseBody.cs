// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddTemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the transcoding template.
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public AddTemplateResponseBodyTemplate Template { get; set; }
        public class AddTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// The audio codec configurations.
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateAudio Audio { get; set; }
            public class AddTemplateResponseBodyTemplateAudio : TeaModel {
                /// <summary>
                /// The audio bitrate of the output file.
                /// 
                /// *   Unit: Kbit/s.
                /// *   Default value: **128**.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The number of sound channels. Default value: **2**.
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// The audio codec format. Default value: **aac**. Valid values:
                /// 
                /// *   **aac**
                /// *   **mp3**
                /// *   **vorbis**
                /// *   **flac**
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// The codec profile of the audio. Valid values if the **Codec** parameter is set to **AAC**:
                /// 
                /// *   **aac_low**
                /// *   **aac_he**
                /// *   **aac_he_v2**
                /// *   **aac_ld**
                /// *   **aac_eld**
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The level of the independent denoising algorithm.
                /// </summary>
                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                /// <summary>
                /// Indicates whether the audio stream is deleted.
                /// 
                /// *   **true**: The audio stream is deleted.
                /// *   **false**: The audio stream is retained.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                /// <summary>
                /// The sampling rate.
                /// 
                /// *   Unit: Hz.
                /// *   Default value: **44100**.
                /// </summary>
                [NameInMap("Samplerate")]
                [Validation(Required=false)]
                public string Samplerate { get; set; }

                /// <summary>
                /// The volume control configurations
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateAudioVolume Volume { get; set; }
                public class AddTemplateResponseBodyTemplateAudioVolume : TeaModel {
                    /// <summary>
                    /// The output volume.
                    /// 
                    /// This parameter takes effect only when the value of Method is dynamic.
                    /// 
                    /// Unit: dB.
                    /// 
                    /// Valid values: [-70,-5].
                    /// 
                    /// Default value: -6.
                    /// </summary>
                    [NameInMap("IntegratedLoudnessTarget")]
                    [Validation(Required=false)]
                    public string IntegratedLoudnessTarget { get; set; }

                    /// <summary>
                    /// The volume adjustment range.
                    /// 
                    /// *   Default value: **-20**.
                    /// *   Unit: dB.
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// The range of the volume relative to the output volume.
                    /// 
                    /// This parameter takes effect only when the value of Method is dynamic.
                    /// 
                    /// Unit: dB.
                    /// 
                    /// Valid values: [1,20].
                    /// 
                    /// Default value: 8.
                    /// </summary>
                    [NameInMap("LoudnessRangeTarget")]
                    [Validation(Required=false)]
                    public string LoudnessRangeTarget { get; set; }

                    /// <summary>
                    /// The volume adjustment method. Valid values:
                    /// 
                    /// *   **auto**: The volume is automatically adjusted.
                    /// *   **dynamic**: The volume is dynamically adjusted.
                    /// *   **linear**: The volume is linearly adjusted.
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// The volume adjustment coefficient.
                    /// 
                    /// This parameter takes effect only when the value of Method is adaptive.
                    /// 
                    /// Valid values: [0,1].
                    /// 
                    /// Default value: 0.9.
                    /// </summary>
                    [NameInMap("PeakLevel")]
                    [Validation(Required=false)]
                    public string PeakLevel { get; set; }

                    /// <summary>
                    /// The peak volume.
                    /// 
                    /// This parameter takes effect only when the value of Method is dynamic.
                    /// 
                    /// Unit: dB.
                    /// 
                    /// Valid values: [-9,0].
                    /// 
                    /// Default value: -1.
                    /// </summary>
                    [NameInMap("TruePeak")]
                    [Validation(Required=false)]
                    public string TruePeak { get; set; }

                }

            }

            /// <summary>
            /// The container format settings.
            /// </summary>
            [NameInMap("Container")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateContainer Container { get; set; }
            public class AddTemplateResponseBodyTemplateContainer : TeaModel {
                /// <summary>
                /// The container format.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

            }

            /// <summary>
            /// The ID of the transcoding template. We recommend that you keep this ID for subsequent operation calls.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The transmuxing settings.
            /// </summary>
            [NameInMap("MuxConfig")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateMuxConfig MuxConfig { get; set; }
            public class AddTemplateResponseBodyTemplateMuxConfig : TeaModel {
                /// <summary>
                /// The transmuxing settings for GIF.
                /// </summary>
                [NameInMap("Gif")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateMuxConfigGif Gif { get; set; }
                public class AddTemplateResponseBodyTemplateMuxConfigGif : TeaModel {
                    /// <summary>
                    /// The color dithering algorithm of the palette. Valid values: sierra and bayer.
                    /// </summary>
                    [NameInMap("DitherMode")]
                    [Validation(Required=false)]
                    public string DitherMode { get; set; }

                    /// <summary>
                    /// The duration for which the final frame is paused. Unit: centiseconds.
                    /// </summary>
                    [NameInMap("FinalDelay")]
                    [Validation(Required=false)]
                    public string FinalDelay { get; set; }

                    /// <summary>
                    /// Indicates whether the custom palette is used.
                    /// </summary>
                    [NameInMap("IsCustomPalette")]
                    [Validation(Required=false)]
                    public string IsCustomPalette { get; set; }

                    /// <summary>
                    /// The loop count.
                    /// </summary>
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }

                }

                /// <summary>
                /// The segment settings.
                /// </summary>
                [NameInMap("Segment")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateMuxConfigSegment Segment { get; set; }
                public class AddTemplateResponseBodyTemplateMuxConfigSegment : TeaModel {
                    /// <summary>
                    /// The length of the segment. Unit: seconds.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                }

                /// <summary>
                /// The transmuxing settings for WebP.
                /// </summary>
                [NameInMap("Webp")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateMuxConfigWebp Webp { get; set; }
                public class AddTemplateResponseBodyTemplateMuxConfigWebp : TeaModel {
                    /// <summary>
                    /// The loop count.
                    /// </summary>
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }

                }

            }

            /// <summary>
            /// The name of the transcoding template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the template. Valid values:
            /// 
            /// *   **Normal**: The template is normal.
            /// *   **Deleted**: The template is deleted.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The general transcoding settings.
            /// </summary>
            [NameInMap("TransConfig")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateTransConfig TransConfig { get; set; }
            public class AddTemplateResponseBodyTemplateTransConfig : TeaModel {
                /// <summary>
                /// The method of resolution adjustment. Default value: **none**. Valid values:
                /// 
                /// *   **rescale**: The input video is rescaled.
                /// *   **crop**: The input video is cropped.
                /// *   **none**: No change is made.
                /// </summary>
                [NameInMap("AdjDarMethod")]
                [Validation(Required=false)]
                public string AdjDarMethod { get; set; }

                /// <summary>
                /// Indicates whether the audio bitrate is checked.
                /// 
                /// If this feature is enabled and the system detects that the audio bitrate of the output file is greater than that of the input file, the audio bitrate of the input file is retained after transcoding.
                /// 
                /// *   **true**: The audio bitrate is checked.
                /// *   **false**: The audio bitrate is not checked.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("IsCheckAudioBitrate")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrate { get; set; }

                /// <summary>
                /// Indicates whether the audio bitrate is checked. If this feature is enabled and the system detects that the audio bitrate of the output file is higher than that of the input file, the input file is not transcoded. This parameter has a higher priority than the **IsCheckAudioBitrate** parameter. Valid values:
                /// 
                /// *   **true**: The audio bitrate is checked. In this case, if the audio bitrate of the output file is higher than that of the input file, the input file is not transcoded.
                /// *   **false**: The audio bitrate is not checked.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("IsCheckAudioBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrateFail { get; set; }

                /// <summary>
                /// Indicates whether the resolution is checked.
                /// 
                /// *   **true**: The resolution is checked.
                /// *   **false**: The resolution is not checked.
                /// *   Default value: **false**.
                /// 
                /// > If this feature is enabled and the system detects that the resolution of the output file is higher than that of the input file based on the width or height, the resolution of the input file is retained after transcoding.
                /// </summary>
                [NameInMap("IsCheckReso")]
                [Validation(Required=false)]
                public string IsCheckReso { get; set; }

                /// <summary>
                /// Indicates whether the resolution is checked.
                /// 
                /// *   **true**: The resolution is checked.
                /// *   **false**: The resolution is not checked.
                /// *   Default value: **false**.
                /// 
                /// > If this feature is enabled and the system detects that the resolution of the output file is higher than that of the input file based on the width or height, an error that indicates a transcoding failure is returned.
                /// </summary>
                [NameInMap("IsCheckResoFail")]
                [Validation(Required=false)]
                public string IsCheckResoFail { get; set; }

                /// <summary>
                /// Indicates whether the video bitrate is checked.
                /// 
                /// *   **true**: The video bitrate is checked.
                /// *   **false**: The video bitrate is not checked.
                /// *   Default value: **false**.
                /// 
                /// > If this feature is enabled and the system detects that the video bitrate of the output file is greater than that of the input file, the video bitrate of the input file is retained after transcoding.
                /// </summary>
                [NameInMap("IsCheckVideoBitrate")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrate { get; set; }

                /// <summary>
                /// Indicates whether the video bitrate is checked. If this feature is enabled and the system detects that the video bitrate of the output file is higher than that of the input file, the input file is not transcoded. This parameter has a higher priority than the IsCheckVideoBitrate parameter.
                /// 
                /// *   **true**: The video bitrate is checked. In this case, if the video bitrate of the output file is higher than that of the input file, the input file is not transcoded.
                /// *   **false**: The video bitrate is not checked.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("IsCheckVideoBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrateFail { get; set; }

                /// <summary>
                /// The transcoding mode. Valid values:
                /// 
                /// *   **onepass**
                /// *   **twopass**
                /// *   **CBR**
                /// *   Default value: **onepass**.
                /// </summary>
                [NameInMap("TransMode")]
                [Validation(Required=false)]
                public string TransMode { get; set; }

            }

            /// <summary>
            /// The video codec configurations.
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateVideo Video { get; set; }
            public class AddTemplateResponseBodyTemplateVideo : TeaModel {
                /// <summary>
                /// The bitrate of the output video. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The bitrate range of the video.
                /// </summary>
                [NameInMap("BitrateBnd")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateVideoBitrateBnd BitrateBnd { get; set; }
                public class AddTemplateResponseBodyTemplateVideoBitrateBnd : TeaModel {
                    /// <summary>
                    /// The maximum bitrate.
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public string Max { get; set; }

                    /// <summary>
                    /// The minimum bitrate.
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public string Min { get; set; }

                }

                /// <summary>
                /// The size of the buffer.
                /// 
                /// *   Default value: **6000**.
                /// *   Unit: KB.
                /// </summary>
                [NameInMap("Bufsize")]
                [Validation(Required=false)]
                public string Bufsize { get; set; }

                /// <summary>
                /// The video codec. Valid values: H.264, H.265, GIF, and WebP. Default value: **H.264**.
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// The constant rate factor. Default value if the video codec is set to H.264: **23**. Default value if the video codec is set to H.265: **26**.
                /// 
                /// > If this parameter is specified, the setting of the Bitrate parameter becomes invalid.
                /// </summary>
                [NameInMap("Crf")]
                [Validation(Required=false)]
                public string Crf { get; set; }

                /// <summary>
                /// The method of video cropping. Valid values:
                /// 
                /// *   **border**: automatically detects and removes borders.
                /// *   **Value in the format of width:height:left:top**: crops the video image based on the custom settings. Example: 1280:800:0:140.
                /// </summary>
                [NameInMap("Crop")]
                [Validation(Required=false)]
                public string Crop { get; set; }

                /// <summary>
                /// The level of quality control on the video.
                /// </summary>
                [NameInMap("Degrain")]
                [Validation(Required=false)]
                public string Degrain { get; set; }

                /// <summary>
                /// The frame rate. Default value: the frame rate of the input file. The value is 60 if the frame rate of the input file exceeds 60. Unit: frames per second.
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// The GOP size. The GOP size can be the maximum interval of keyframes or the maximum number of frames in a frame group. If the maximum interval is specified, the value contains the unit (s). If the maximum number of frames is specified, the value does not contain a unit. Default value: **10s**.
                /// </summary>
                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                /// <summary>
                /// Indicates whether the HDR2SDR conversion feature is enabled. If this feature is enabled, high dynamic range (HDR) videos are transcoded to standard dynamic range (SDR) videos.
                /// </summary>
                [NameInMap("Hdr2sdr")]
                [Validation(Required=false)]
                public string Hdr2sdr { get; set; }

                /// <summary>
                /// The height of the video.
                /// 
                /// *   Unit: pixel.
                /// *   Default value: the height of the input video.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// Indicates whether the auto-rotate screen feature is enabled. Default value: **false**. Valid values:
                /// 
                /// *   **true**: The auto-rotate screen feature is enabled.
                /// *   **false**: The auto-rotate screen feature is disabled.
                /// 
                /// > If this feature is enabled, the width of the output video corresponds to the long side of the input video, which is the height of the input video in portrait mode. The height of the output video corresponds to the short side of the input video, which is the width of the input video in portrait mode.
                /// </summary>
                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public string LongShortMode { get; set; }

                /// <summary>
                /// The maximum frame rate.
                /// </summary>
                [NameInMap("MaxFps")]
                [Validation(Required=false)]
                public string MaxFps { get; set; }

                /// <summary>
                /// The maximum bitrate of the video. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Maxrate")]
                [Validation(Required=false)]
                public string Maxrate { get; set; }

                /// <summary>
                /// The Narrowband HD settings.
                /// </summary>
                [NameInMap("NarrowBand")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateVideoNarrowBand NarrowBand { get; set; }
                public class AddTemplateResponseBodyTemplateVideoNarrowBand : TeaModel {
                    /// <summary>
                    /// The upper limit of the dynamic bitrate. If this parameter is set, the average bitrate is in the range of (0, 1000000].
                    /// </summary>
                    [NameInMap("Abrmax")]
                    [Validation(Required=false)]
                    public float? Abrmax { get; set; }

                    /// <summary>
                    /// The maximum ratio of the upper limit of dynamic bitrate. If this parameter is set, the value of Abrmax does not exceed x times of the source video bitrate. Valid values: (0,1.0].
                    /// </summary>
                    [NameInMap("MaxAbrRatio")]
                    [Validation(Required=false)]
                    public float? MaxAbrRatio { get; set; }

                    /// <summary>
                    /// The Narrowband HD version. Only 1.0 may be returned.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// The black borders to be added to the video. The value is in the width:height:left:top format.
                /// </summary>
                [NameInMap("Pad")]
                [Validation(Required=false)]
                public string Pad { get; set; }

                /// <summary>
                /// The pixel format. Standard pixel formats such as yuv420p and yuvj420p are supported. The default pixel format can be **yuv420p** or the pixel format of the input video.
                /// </summary>
                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                /// <summary>
                /// The preset video algorithm. Default value: **medium**. Valid values:
                /// 
                /// *   **veryfast**
                /// *   **fast**
                /// *   **medium**
                /// *   **slow**
                /// *   **slower**
                /// 
                /// > This parameter is valid only if the Codec parameter is set to H.264.
                /// </summary>
                [NameInMap("Preset")]
                [Validation(Required=false)]
                public string Preset { get; set; }

                /// <summary>
                /// The codec profile.
                /// 
                /// *   **baseline**: suitable for mobile devices
                /// *   **main**: suitable for standard-definition devices
                /// *   **high**: suitable for high-definition devices
                /// *   Default value: **high**.
                /// 
                /// If multiple definitions are available, we recommend that you set this parameter to baseline for the lowest definition to ensure normal playback on low-end devices. Set this parameter to main or high for other definitions.
                /// 
                /// > This parameter is valid only if the Codec parameter is set to H.264.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The level of the independent denoising algorithm.
                /// </summary>
                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                /// <summary>
                /// Indicates whether the video stream is deleted.
                /// 
                /// *   **true**: The video stream is deleted.
                /// *   **false**: The video stream is retained.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                /// <summary>
                /// The policy of resolution adjustment.
                /// </summary>
                [NameInMap("ResoPriority")]
                [Validation(Required=false)]
                public string ResoPriority { get; set; }

                /// <summary>
                /// The scan mode. Valid values:
                /// 
                /// *   **interlaced**
                /// *   **progressive**
                /// </summary>
                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

                /// <summary>
                /// The width of the video.
                /// 
                /// *   Default value: the width of the input video.****
                /// *   Unit: pixel.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

    }

}
