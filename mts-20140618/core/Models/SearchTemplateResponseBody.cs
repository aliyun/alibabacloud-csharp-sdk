// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchTemplateResponseBody : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The transcoding templates.
        /// </summary>
        [NameInMap("TemplateList")]
        [Validation(Required=false)]
        public SearchTemplateResponseBodyTemplateList TemplateList { get; set; }
        public class SearchTemplateResponseBodyTemplateList : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<SearchTemplateResponseBodyTemplateListTemplate> Template { get; set; }
            public class SearchTemplateResponseBodyTemplateListTemplate : TeaModel {
                /// <summary>
                /// The audio codec configurations.
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateAudio Audio { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateAudio : TeaModel {
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
                    /// The codec profile of the audio. Valid values when the value of Codec is aac:
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
                    /// The strength of the independent denoising algorithm. Valid values: **[1,9]**.
                    /// </summary>
                    [NameInMap("Qscale")]
                    [Validation(Required=false)]
                    public string Qscale { get; set; }

                    /// <summary>
                    /// Indicates whether the audio stream is deleted. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// *   Default value: **false**.
                    /// </summary>
                    [NameInMap("Remove")]
                    [Validation(Required=false)]
                    public string Remove { get; set; }

                    /// <summary>
                    /// The sampling rate.
                    /// 
                    /// *   Unit: Hz
                    /// *   Default value: **44100**.
                    /// </summary>
                    [NameInMap("Samplerate")]
                    [Validation(Required=false)]
                    public string Samplerate { get; set; }

                }

                /// <summary>
                /// The container format configurations.
                /// </summary>
                [NameInMap("Container")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateContainer Container { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateContainer : TeaModel {
                    /// <summary>
                    /// The format of the container. Valid values:
                    /// 
                    /// *   **flv**
                    /// *   **mp4**
                    /// *   **ts**
                    /// *   **m3u8**
                    /// *   **gif**
                    /// *   **mp3**
                    /// *   **ogg**
                    /// *   **flac**
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                }

                /// <summary>
                /// The time when the template was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The transcoding template ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The transmuxing configurations.
                /// </summary>
                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateMuxConfig MuxConfig { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateMuxConfig : TeaModel {
                    /// <summary>
                    /// The transmuxing configurations for GIF.
                    /// </summary>
                    [NameInMap("Gif")]
                    [Validation(Required=false)]
                    public SearchTemplateResponseBodyTemplateListTemplateMuxConfigGif Gif { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateMuxConfigGif : TeaModel {
                        /// <summary>
                        /// The color dithering algorithm of the palette. Valid values: sierra and bayer.
                        /// </summary>
                        [NameInMap("DitherMode")]
                        [Validation(Required=false)]
                        public string DitherMode { get; set; }

                        /// <summary>
                        /// The duration for which the final frame is paused. Unit: centisecond.
                        /// </summary>
                        [NameInMap("FinalDelay")]
                        [Validation(Required=false)]
                        public string FinalDelay { get; set; }

                        /// <summary>
                        /// Indicates whether a custom palette is used.
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
                    /// The segment configurations.
                    /// </summary>
                    [NameInMap("Segment")]
                    [Validation(Required=false)]
                    public SearchTemplateResponseBodyTemplateListTemplateMuxConfigSegment Segment { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateMuxConfigSegment : TeaModel {
                        /// <summary>
                        /// The length of the segment. Unit: seconds.
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }

                    }

                }

                /// <summary>
                /// The name of the template.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the template. Valid values:
                /// 
                /// *   **Normal**
                /// *   **Deleted**
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The general transcoding configurations.
                /// </summary>
                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateTransConfig TransConfig { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateTransConfig : TeaModel {
                    /// <summary>
                    /// The method of resolution adjustment. Default value: **none**. Valid values:
                    /// 
                    /// *   rescale
                    /// *   crop
                    /// *   none
                    /// </summary>
                    [NameInMap("AdjDarMethod")]
                    [Validation(Required=false)]
                    public string AdjDarMethod { get; set; }

                    /// <summary>
                    /// Indicates whether the audio bitrate is checked. If the bitrate of the output audio is higher than that of the input audio, the input bitrate is retained and the specified audio bitrate does not take effect. This parameter has a lower priority than IsCheckAudioBitrateFail. Valid values:
                    /// 
                    /// *   **true**
                    /// 
                    /// *   **false**
                    /// 
                    /// *   Default value:
                    /// 
                    ///     *   If this parameter is empty and the codec of the output audio is different from that of the input audio, the default value is false.
                    ///     *   If this parameter is empty and the codec of the output audio is the same as that of the input audio, the default value is true.
                    /// </summary>
                    [NameInMap("IsCheckAudioBitrate")]
                    [Validation(Required=false)]
                    public string IsCheckAudioBitrate { get; set; }

                    /// <summary>
                    /// Indicates whether audio bitrate check errors are allowed. This parameter has a greater priority than IsCheckAudioBitrate. Valid values:
                    /// 
                    /// *   **true**: If the audio bitrate check fails, the input file is not transcoded.
                    /// *   **false**: The audio bitrate is not checked.
                    /// *   Default value: **false**.
                    /// </summary>
                    [NameInMap("IsCheckAudioBitrateFail")]
                    [Validation(Required=false)]
                    public string IsCheckAudioBitrateFail { get; set; }

                    /// <summary>
                    /// Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, the input resolution is retained. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// *   Default value: **false**.
                    /// </summary>
                    [NameInMap("IsCheckReso")]
                    [Validation(Required=false)]
                    public string IsCheckReso { get; set; }

                    /// <summary>
                    /// Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, a transcoding failure is returned. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// *   Default value: **false**.
                    /// </summary>
                    [NameInMap("IsCheckResoFail")]
                    [Validation(Required=false)]
                    public string IsCheckResoFail { get; set; }

                    /// <summary>
                    /// Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, the input bitrate is retained. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// *   Default value: **false**.
                    /// </summary>
                    [NameInMap("IsCheckVideoBitrate")]
                    [Validation(Required=false)]
                    public string IsCheckVideoBitrate { get; set; }

                    /// <summary>
                    /// Indicates whether video bitrate check errors are allowed. This parameter has a higher priority than IsCheckVideoBitrate. Valid values:
                    /// 
                    /// *   **true**: If the video bitrate check fails, the input file is not transcoded.
                    /// *   **false**: The video bitrate is not checked.
                    /// *   Default value: **false**.
                    /// </summary>
                    [NameInMap("IsCheckVideoBitrateFail")]
                    [Validation(Required=false)]
                    public string IsCheckVideoBitrateFail { get; set; }

                    /// <summary>
                    /// The transcoding mode. Default value: **onepass**. Valid values:
                    /// 
                    /// *   **onepass**
                    /// *   **twopass**
                    /// *   **CBR**
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
                public SearchTemplateResponseBodyTemplateListTemplateVideo Video { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateVideo : TeaModel {
                    /// <summary>
                    /// The average bitrate of the video. Unit: Kbit/s.
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// The average bitrate range of the video.
                    /// </summary>
                    [NameInMap("BitrateBnd")]
                    [Validation(Required=false)]
                    public SearchTemplateResponseBodyTemplateListTemplateVideoBitrateBnd BitrateBnd { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateVideoBitrateBnd : TeaModel {
                        /// <summary>
                        /// The upper limit of the total bitrate. Unit: Kbit/s.
                        /// </summary>
                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public string Max { get; set; }

                        /// <summary>
                        /// The lower limit of the total bitrate. Unit: Kbit/s.
                        /// </summary>
                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public string Min { get; set; }

                    }

                    /// <summary>
                    /// The buffer size.
                    /// 
                    /// *   Unit: KB.
                    /// *   Default value: **6000**.
                    /// </summary>
                    [NameInMap("Bufsize")]
                    [Validation(Required=false)]
                    public string Bufsize { get; set; }

                    /// <summary>
                    /// The codec.
                    /// 
                    /// *   Valid values: H.264 and H.265.
                    /// *   Default value: **H.264**.
                    /// </summary>
                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    /// <summary>
                    /// The constant rate factor.
                    /// 
                    /// *   Default value when the value of Codec is H.264: **23**, default value when the value of Codec is H.265: **26**.
                    /// *   If this parameter is set, the value of Bitrate becomes invalid.
                    /// </summary>
                    [NameInMap("Crf")]
                    [Validation(Required=false)]
                    public string Crf { get; set; }

                    /// <summary>
                    /// The method of video cropping. Valid values:
                    /// 
                    /// *   **border**: automatically detects and removes black bars.
                    /// *   **Value in the width:height:left:top format**: crops the video image based on the custom settings. Format: width:height:left:top. Example: 1280:800:0:140.
                    /// </summary>
                    [NameInMap("Crop")]
                    [Validation(Required=false)]
                    public string Crop { get; set; }

                    /// <summary>
                    /// The level of video quality control.
                    /// </summary>
                    [NameInMap("Degrain")]
                    [Validation(Required=false)]
                    public string Degrain { get; set; }

                    /// <summary>
                    /// The frame rate of the video.
                    /// 
                    /// *   The value is 60 if the frame rate of the input video exceeds 60.
                    /// *   Default value: **the frame rate of the input video**.
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// The maximum number of frames between two keyframes. Default value: **250**.
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
                    /// *   Default value: **the height of the input video**.
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// Indicates whether the auto-rotate screen feature is enabled.
                    /// 
                    /// *   If this feature is enabled, the width of the output video corresponds to the long side of the input video, which is the height of the input video in portrait mode. The height of the output video corresponds to the short side of the input video, which is the width of the input video in portrait mode. Valid values:
                    /// *   **true**
                    /// *   **false**
                    /// *   Default value: **false**.
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
                    public SearchTemplateResponseBodyTemplateListTemplateVideoNarrowBand NarrowBand { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateVideoNarrowBand : TeaModel {
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
                    /// The black bars that are added to the video.
                    /// 
                    /// *   Format: width:height:left:top.
                    /// *   Example: 1280:800:0:140.
                    /// </summary>
                    [NameInMap("Pad")]
                    [Validation(Required=false)]
                    public string Pad { get; set; }

                    /// <summary>
                    /// The pixel format of the video. Valid values: standard pixel formats such as yuv420p and yuvj420p.
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
                    /// </summary>
                    [NameInMap("Preset")]
                    [Validation(Required=false)]
                    public string Preset { get; set; }

                    /// <summary>
                    /// The codec profile. Valid values:
                    /// 
                    /// *   **baseline**: applicable to mobile devices.
                    /// *   **main**: applicable to standard-definition devices.
                    /// *   **high**: applicable to high-definition devices.
                    /// *   Default value: **high**.
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// The strength of the independent denoising algorithm.
                    /// </summary>
                    [NameInMap("Qscale")]
                    [Validation(Required=false)]
                    public string Qscale { get; set; }

                    /// <summary>
                    /// Indicates whether the video stream is deleted. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
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
                    /// *   Valid values: **[128,4096]**.
                    /// *   Unit: pixel.
                    /// *   Default value: **the width of the input video**.
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

        }

        /// <summary>
        /// The total number of search results.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
