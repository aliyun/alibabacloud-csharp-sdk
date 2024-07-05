// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateTemplateResponseBody : TeaModel {
        /// <summary>
        /// The type of the transcoding template.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the transcoding template.
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public UpdateTemplateResponseBodyTemplate Template { get; set; }
        public class UpdateTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// The audio codec settings.
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateAudio Audio { get; set; }
            public class UpdateTemplateResponseBodyTemplateAudio : TeaModel {
                /// <summary>
                /// The ID of the transcoding template.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The audio bitrate of the output file.
                /// 
                /// *   Valid values: 8 to 1000.****
                /// *   Unit: Kbit/s.
                /// *   Default value: **128**.
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// The sampling rate.
                /// 
                /// *   Unit: Hz.
                /// *   Default value: **44100**.
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// Indicates whether the audio stream is deleted.
                /// 
                /// *   **true**: The audio stream is deleted.
                /// *   **false**: The audio stream is retained.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The number of sound channels. Default value: **2**.
                /// </summary>
                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                /// <summary>
                /// The audio codec format. Default value: **aac**. Valid values:
                /// 
                /// *   **aac**
                /// *   **mp3**
                /// *   **vorbis**
                /// *   **flac**
                /// </summary>
                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                /// <summary>
                /// The level of the independent denoising algorithm.
                /// </summary>
                [NameInMap("Samplerate")]
                [Validation(Required=false)]
                public string Samplerate { get; set; }

                /// <summary>
                /// The volume control configurations.
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateAudioVolume Volume { get; set; }
                public class UpdateTemplateResponseBodyTemplateAudioVolume : TeaModel {
                    /// <summary>
                    /// The expected volume.
                    /// 
                    /// *   This parameter takes effect only if the value of Method is dynamic.
                    /// *   Unit: decibel.
                    /// *   Valid values: [-70,-5].
                    /// *   Default value: -6.
                    /// </summary>
                    [NameInMap("IntegratedLoudnessTarget")]
                    [Validation(Required=false)]
                    public string IntegratedLoudnessTarget { get; set; }

                    /// <summary>
                    /// The increased volume relative to the volume of the input audio.
                    /// 
                    /// *   This parameter takes effect only if the value of Method is linear.
                    /// *   Unit: decibel.
                    /// *   Valid values: less than or equal to 20.
                    /// *   Default value: -20.
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// The range of the volume relative to the expected volume.
                    /// 
                    /// *   This parameter takes effect only if the value of Method is dynamic.
                    /// *   Unit: decibel.
                    /// *   Valid values: [1,20].
                    /// *   Default value: 8.
                    /// </summary>
                    [NameInMap("LoudnessRangeTarget")]
                    [Validation(Required=false)]
                    public string LoudnessRangeTarget { get; set; }

                    /// <summary>
                    /// The volume adjustment method. Valid values:
                    /// 
                    /// *   **auto**
                    /// *   **dynamic**
                    /// *   **linear**
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// The volume adjustment coefficient.
                    /// 
                    /// This parameter takes effect only if the value of Method is adaptive.
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
                    /// *   This parameter takes effect only if the value of Method is dynamic.
                    /// *   Unit: decibel.
                    /// *   Valid values: [-9,0].
                    /// *   Default value: -1.
                    /// </summary>
                    [NameInMap("TruePeak")]
                    [Validation(Required=false)]
                    public string TruePeak { get; set; }

                }

            }

            /// <summary>
            /// The container format.
            /// </summary>
            [NameInMap("Container")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateContainer Container { get; set; }
            public class UpdateTemplateResponseBodyTemplateContainer : TeaModel {
                /// <summary>
                /// The container format.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

            }

            /// <summary>
            /// The container configurations.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The transmuxing configurations for WebP.
            /// </summary>
            [NameInMap("MuxConfig")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateMuxConfig MuxConfig { get; set; }
            public class UpdateTemplateResponseBodyTemplateMuxConfig : TeaModel {
                /// <summary>
                /// The duration for which the final frame is paused. Unit: milliseconds.
                /// </summary>
                [NameInMap("Gif")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateMuxConfigGif Gif { get; set; }
                public class UpdateTemplateResponseBodyTemplateMuxConfigGif : TeaModel {
                    /// <summary>
                    /// The loop count.
                    /// </summary>
                    [NameInMap("DitherMode")]
                    [Validation(Required=false)]
                    public string DitherMode { get; set; }

                    /// <summary>
                    /// The color dithering algorithm of the palette. Valid values: sierra and bayer.
                    /// </summary>
                    [NameInMap("FinalDelay")]
                    [Validation(Required=false)]
                    public string FinalDelay { get; set; }

                    /// <summary>
                    /// The segment configurations.
                    /// </summary>
                    [NameInMap("IsCustomPalette")]
                    [Validation(Required=false)]
                    public string IsCustomPalette { get; set; }

                    /// <summary>
                    /// Indicates whether the custom palette is used.
                    /// </summary>
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }

                }

                /// <summary>
                /// The length of the segment. Unit: seconds.
                /// </summary>
                [NameInMap("Segment")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateMuxConfigSegment Segment { get; set; }
                public class UpdateTemplateResponseBodyTemplateMuxConfigSegment : TeaModel {
                    /// <summary>
                    /// The name of the template.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                }

                /// <summary>
                /// The loop count.
                /// </summary>
                [NameInMap("Webp")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateMuxConfigWebp Webp { get; set; }
                public class UpdateTemplateResponseBodyTemplateMuxConfigWebp : TeaModel {
                    /// <summary>
                    /// The transmuxing configurations for GIF.
                    /// </summary>
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }

                }

            }

            /// <summary>
            /// The audio codec configurations.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The transmuxing configurations.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Indicates whether the audio bitrate is checked. If the bitrate of the output audio is greater than the bitrate of the input audio, the bitrate of the input audio is retained after transcoding. In this case, the specified audio bitrate does not take effect. This parameter has a lower priority than the IsCheckAudioBitrateFail parameter. Valid values:
            /// 
            /// *   **true**: The audio bitrate is checked.
            /// 
            /// *   **false**: The audio bitrate is not checked.
            /// 
            /// *   Default value:
            /// 
            ///     *   If the parameter is left empty and the codec of the output audio is different from that of the input audio, the default value is false.
            ///     *   If the parameter is left empty and the codec of the output audio is the same as that of the input audio, the default value is true.
            /// </summary>
            [NameInMap("TransConfig")]
            [Validation(Required=false)]
            public UpdateTemplateResponseBodyTemplateTransConfig TransConfig { get; set; }
            public class UpdateTemplateResponseBodyTemplateTransConfig : TeaModel {
                /// <summary>
                /// Indicates whether the video bitrate is checked. If this parameter is set to true and the system detects that the video bitrate of the output file is greater than that of the input file, the video bitrate of the input file is retained after transcoding. Valid values:
                /// 
                /// *   **true**: The video bitrate is checked.
                /// *   **false**: The video bitrate is not checked.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("AdjDarMethod")]
                [Validation(Required=false)]
                public string AdjDarMethod { get; set; }

                /// <summary>
                /// The transcoding mode. Default value: **onepass**. Valid values:
                /// 
                /// *   **onepass**
                /// *   **twopass**
                /// *   **CBR**
                /// </summary>
                [NameInMap("IsCheckAudioBitrate")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrate { get; set; }

                /// <summary>
                /// The status of the template. Valid values:
                /// 
                /// *   **Normal**: The template is normal.
                /// *   **Deleted**: The template is deleted.
                /// </summary>
                [NameInMap("IsCheckAudioBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrateFail { get; set; }

                /// <summary>
                /// Indicates whether the video bitrate is checked. This parameter has a higher priority than the IsCheckVideoBitrate parameter. Valid values:
                /// 
                /// *   **true**: The video bitrate is checked
                /// *   **false**: The video bitrate is not checked.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("IsCheckReso")]
                [Validation(Required=false)]
                public string IsCheckReso { get; set; }

                /// <summary>
                /// Indicates whether the audio bitrate is checked. This parameter has a higher priority than the IsCheckAudioBitrate parameter. Valid values:
                /// 
                /// *   **true**: The audio bitrate is checked.
                /// *   **false**: The audio bitrate is not checked.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("IsCheckResoFail")]
                [Validation(Required=false)]
                public string IsCheckResoFail { get; set; }

                /// <summary>
                /// Indicates whether the resolution is checked. If this parameter is set to true and the system detects that the resolution of the output file is higher than that of the input file based on the width or height, an error that indicates a transcoding failure is returned. Valid values:
                /// 
                /// *   **true**: The resolution is checked.
                /// *   **false**: The resolution is not checked.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("IsCheckVideoBitrate")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrate { get; set; }

                /// <summary>
                /// The method of resolution adjustment. Default value: **none**. Valid values:
                /// 
                /// *   rescale: The input video is rescaled.
                /// *   crop: The input video is cropped.
                /// *   none: No change is made.
                /// </summary>
                [NameInMap("IsCheckVideoBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrateFail { get; set; }

                /// <summary>
                /// Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, the input resolution is retained after transcoding. Valid values:
                /// 
                /// *   **true**: The resolution is checked.
                /// *   **false**: The resolution is not checked.
                /// *   Default value: **false**.
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
            public UpdateTemplateResponseBodyTemplateVideo Video { get; set; }
            public class UpdateTemplateResponseBodyTemplateVideo : TeaModel {
                /// <summary>
                /// The maximum bitrate of the video. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The upper limit of the total bitrate. Unit: Kbit/s.
                /// </summary>
                [NameInMap("BitrateBnd")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateVideoBitrateBnd BitrateBnd { get; set; }
                public class UpdateTemplateResponseBodyTemplateVideoBitrateBnd : TeaModel {
                    /// <summary>
                    /// The lower limit of the total bitrate. Unit: Kbit/s.
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public string Max { get; set; }

                    /// <summary>
                    /// The pixel format. Valid values: standard pixel formats such as yuv420p and yuvj420p.
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public string Min { get; set; }

                }

                /// <summary>
                /// The level of quality control on the video.
                /// </summary>
                [NameInMap("Bufsize")]
                [Validation(Required=false)]
                public string Bufsize { get; set; }

                /// <summary>
                /// The height of the output video.
                /// 
                /// *   Unit: pixel.
                /// *   Default value: the height of the input video.
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// Indicates whether the video stream is deleted. Valid values:
                /// 
                /// *   **true**: The video stream is deleted.
                /// *   **false**: The video stream is retained.
                /// *   Default value: **false**.
                /// </summary>
                [NameInMap("Crf")]
                [Validation(Required=false)]
                public string Crf { get; set; }

                /// <summary>
                /// The average bitrate of the video. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Crop")]
                [Validation(Required=false)]
                public string Crop { get; set; }

                /// <summary>
                /// The average bitrate range of the video.
                /// </summary>
                [NameInMap("Degrain")]
                [Validation(Required=false)]
                public string Degrain { get; set; }

                /// <summary>
                /// The preset video algorithm. Default value: **medium**. Valid values:
                /// 
                /// *   **veryfast**
                /// *   **fast**
                /// *   **medium**
                /// *   **slow**
                /// *   **slower**
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// The width of the video.
                /// 
                /// *   Unit: pixel.
                /// *   Default value: **the width of the input video**.
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
                /// The level of the independent denoising algorithm.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// The size of the buffer.
                /// 
                /// *   Unit: KB.
                /// *   Default value: **6000**.
                /// </summary>
                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public string LongShortMode { get; set; }

                /// <summary>
                /// The encoding profile. Valid values:
                /// 
                /// *   **baseline**: applicable to mobile devices.
                /// *   **main**: applicable to standard-definition devices.
                /// *   **high**: applicable to high-definition devices.
                /// *   Default value: **high**.
                /// </summary>
                [NameInMap("MaxFps")]
                [Validation(Required=false)]
                public string MaxFps { get; set; }

                /// <summary>
                /// The maximum frame rate.
                /// </summary>
                [NameInMap("Maxrate")]
                [Validation(Required=false)]
                public string Maxrate { get; set; }

                /// <summary>
                /// The Narrowband HD settings.
                /// </summary>
                [NameInMap("NarrowBand")]
                [Validation(Required=false)]
                public UpdateTemplateResponseBodyTemplateVideoNarrowBand NarrowBand { get; set; }
                public class UpdateTemplateResponseBodyTemplateVideoNarrowBand : TeaModel {
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
                /// The video codec. Default value: **H.264**.
                /// </summary>
                [NameInMap("Pad")]
                [Validation(Required=false)]
                public string Pad { get; set; }

                /// <summary>
                /// The black borders added to the video.
                /// 
                /// *   Format: width:height:left:top.
                /// *   Example: 1280:800:0:140.
                /// </summary>
                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                /// <summary>
                /// The scan mode. Valid values:
                /// 
                /// *   **interlaced**: An interlaced scan is performed.
                /// *   **progressive**: A progressive scan is performed.
                /// </summary>
                [NameInMap("Preset")]
                [Validation(Required=false)]
                public string Preset { get; set; }

                /// <summary>
                /// The bitrate quality control factor.
                /// 
                /// *   Default value if the Codec parameter is set to H.264: **23**. Default value if the Codec parameter is set to H.265: **26**.
                /// *   If this parameter is returned, the setting of the Bitrate parameter is invalid.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The method used to crop the video.
                /// 
                /// *   **border**: automatically detects and removes borders.
                /// *   Value in the width:height:left:top format: crops the video based on custom settings.**** Example: 1280:800:0:140.
                /// </summary>
                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                /// <summary>
                /// The maximum number of frames between two keyframes. Default value: **250**.
                /// </summary>
                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                /// <summary>
                /// The general transcoding configurations.
                /// </summary>
                [NameInMap("ResoPriority")]
                [Validation(Required=false)]
                public string ResoPriority { get; set; }

                /// <summary>
                /// The policy of resolution adjustment.
                /// </summary>
                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

                /// <summary>
                /// The frame rate.
                /// 
                /// *   A value of 60 is returned if the frame rate of the input video exceeds 60.
                /// *   Default value: the frame rate of the input video.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

    }

}
