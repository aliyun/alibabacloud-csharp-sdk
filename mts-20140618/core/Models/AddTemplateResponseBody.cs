// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA258E67-09B8-4EAA-8F33-BA567834A2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the transcoding template.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public AddTemplateResponseBodyTemplate Template { get; set; }
        public class AddTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The audio codec configurations.</para>
            /// </summary>
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateAudio Audio { get; set; }
            public class AddTemplateResponseBodyTemplateAudio : TeaModel {
                /// <summary>
                /// <para>The audio bitrate of the output file.</para>
                /// <list type="bullet">
                /// <item><description>Unit: Kbit/s.</description></item>
                /// <item><description>Default value: <b>128</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The number of sound channels. Default value: <b>2</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// <para>The audio codec format. Default value: <b>aac</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>aac</b></description></item>
                /// <item><description><b>mp3</b></description></item>
                /// <item><description><b>vorbis</b></description></item>
                /// <item><description><b>flac</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aac</para>
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// <para>The codec profile of the audio. Valid values if the <b>Codec</b> parameter is set to <b>AAC</b>:</para>
                /// <list type="bullet">
                /// <item><description><b>aac_low</b></description></item>
                /// <item><description><b>aac_he</b></description></item>
                /// <item><description><b>aac_he_v2</b></description></item>
                /// <item><description><b>aac_ld</b></description></item>
                /// <item><description><b>aac_eld</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aac_low</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The level of the independent denoising algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                /// <summary>
                /// <para>Indicates whether the audio stream is deleted.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The audio stream is deleted.</description></item>
                /// <item><description><b>false</b>: The audio stream is retained.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                /// <summary>
                /// <para>The sampling rate.</para>
                /// <list type="bullet">
                /// <item><description>Unit: Hz.</description></item>
                /// <item><description>Default value: <b>44100</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>44100</para>
                /// </summary>
                [NameInMap("Samplerate")]
                [Validation(Required=false)]
                public string Samplerate { get; set; }

                /// <summary>
                /// <para>The volume control configurations</para>
                /// </summary>
                [NameInMap("Volume")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateAudioVolume Volume { get; set; }
                public class AddTemplateResponseBodyTemplateAudioVolume : TeaModel {
                    /// <summary>
                    /// <para>The output volume.</para>
                    /// <para>This parameter takes effect only when the value of Method is dynamic.</para>
                    /// <para>Unit: dB.</para>
                    /// <para>Valid values: [-70,-5].</para>
                    /// <para>Default value: -6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-6</para>
                    /// </summary>
                    [NameInMap("IntegratedLoudnessTarget")]
                    [Validation(Required=false)]
                    public string IntegratedLoudnessTarget { get; set; }

                    /// <summary>
                    /// <para>The volume adjustment range.</para>
                    /// <list type="bullet">
                    /// <item><description>Default value: <b>-20</b>.</description></item>
                    /// <item><description>Unit: dB.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-20</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The range of the volume relative to the output volume.</para>
                    /// <para>This parameter takes effect only when the value of Method is dynamic.</para>
                    /// <para>Unit: dB.</para>
                    /// <para>Valid values: [1,20].</para>
                    /// <para>Default value: 8.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("LoudnessRangeTarget")]
                    [Validation(Required=false)]
                    public string LoudnessRangeTarget { get; set; }

                    /// <summary>
                    /// <para>The volume adjustment method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>auto</b>: The volume is automatically adjusted.</description></item>
                    /// <item><description><b>dynamic</b>: The volume is dynamically adjusted.</description></item>
                    /// <item><description><b>linear</b>: The volume is linearly adjusted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>auto</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>The volume adjustment coefficient.</para>
                    /// <para>This parameter takes effect only when the value of Method is adaptive.</para>
                    /// <para>Valid values: [0,1].</para>
                    /// <para>Default value: 0.9.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.9</para>
                    /// </summary>
                    [NameInMap("PeakLevel")]
                    [Validation(Required=false)]
                    public string PeakLevel { get; set; }

                    /// <summary>
                    /// <para>The peak volume.</para>
                    /// <para>This parameter takes effect only when the value of Method is dynamic.</para>
                    /// <para>Unit: dB.</para>
                    /// <para>Valid values: [-9,0].</para>
                    /// <para>Default value: -1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
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
            public AddTemplateResponseBodyTemplateContainer Container { get; set; }
            public class AddTemplateResponseBodyTemplateContainer : TeaModel {
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
            /// <para>The ID of the transcoding template. We recommend that you keep this ID for subsequent operation calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16f01ad6175e4230ac42bb5182cd****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The transmuxing settings.</para>
            /// </summary>
            [NameInMap("MuxConfig")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateMuxConfig MuxConfig { get; set; }
            public class AddTemplateResponseBodyTemplateMuxConfig : TeaModel {
                /// <summary>
                /// <para>The transmuxing settings for GIF.</para>
                /// </summary>
                [NameInMap("Gif")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateMuxConfigGif Gif { get; set; }
                public class AddTemplateResponseBodyTemplateMuxConfigGif : TeaModel {
                    /// <summary>
                    /// <para>The color dithering algorithm of the palette. Valid values: sierra and bayer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sierra</para>
                    /// </summary>
                    [NameInMap("DitherMode")]
                    [Validation(Required=false)]
                    public string DitherMode { get; set; }

                    /// <summary>
                    /// <para>The duration for which the final frame is paused. Unit: centiseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FinalDelay")]
                    [Validation(Required=false)]
                    public string FinalDelay { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the custom palette is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCustomPalette")]
                    [Validation(Required=false)]
                    public string IsCustomPalette { get; set; }

                    /// <summary>
                    /// <para>The loop count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }

                }

                /// <summary>
                /// <para>The segment settings.</para>
                /// </summary>
                [NameInMap("Segment")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateMuxConfigSegment Segment { get; set; }
                public class AddTemplateResponseBodyTemplateMuxConfigSegment : TeaModel {
                    /// <summary>
                    /// <para>The length of the segment. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                }

                /// <summary>
                /// <para>The transmuxing settings for WebP.</para>
                /// </summary>
                [NameInMap("Webp")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateMuxConfigWebp Webp { get; set; }
                public class AddTemplateResponseBodyTemplateMuxConfigWebp : TeaModel {
                    /// <summary>
                    /// <para>The loop count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Loop")]
                    [Validation(Required=false)]
                    public string Loop { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the transcoding template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mps-example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The template is normal.</description></item>
            /// <item><description><b>Deleted</b>: The template is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The general transcoding settings.</para>
            /// </summary>
            [NameInMap("TransConfig")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateTransConfig TransConfig { get; set; }
            public class AddTemplateResponseBodyTemplateTransConfig : TeaModel {
                /// <summary>
                /// <para>The method of resolution adjustment. Default value: <b>none</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>rescale</b>: The input video is rescaled.</description></item>
                /// <item><description><b>crop</b>: The input video is cropped.</description></item>
                /// <item><description><b>none</b>: No change is made.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>rescale</para>
                /// </summary>
                [NameInMap("AdjDarMethod")]
                [Validation(Required=false)]
                public string AdjDarMethod { get; set; }

                /// <summary>
                /// <para>Indicates whether the audio bitrate is checked.</para>
                /// <para>If this feature is enabled and the system detects that the audio bitrate of the output file is greater than that of the input file, the audio bitrate of the input file is retained after transcoding.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The audio bitrate is checked.</description></item>
                /// <item><description><b>false</b>: The audio bitrate is not checked.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCheckAudioBitrate")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrate { get; set; }

                /// <summary>
                /// <para>Indicates whether the audio bitrate is checked. If this feature is enabled and the system detects that the audio bitrate of the output file is higher than that of the input file, the input file is not transcoded. This parameter has a higher priority than the <b>IsCheckAudioBitrate</b> parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The audio bitrate is checked. In this case, if the audio bitrate of the output file is higher than that of the input file, the input file is not transcoded.</description></item>
                /// <item><description><b>false</b>: The audio bitrate is not checked.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCheckAudioBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckAudioBitrateFail { get; set; }

                /// <summary>
                /// <para>Indicates whether the resolution is checked.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The resolution is checked.</description></item>
                /// <item><description><b>false</b>: The resolution is not checked.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If this feature is enabled and the system detects that the resolution of the output file is higher than that of the input file based on the width or height, the resolution of the input file is retained after transcoding.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCheckReso")]
                [Validation(Required=false)]
                public string IsCheckReso { get; set; }

                /// <summary>
                /// <para>Indicates whether the resolution is checked.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The resolution is checked.</description></item>
                /// <item><description><b>false</b>: The resolution is not checked.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If this feature is enabled and the system detects that the resolution of the output file is higher than that of the input file based on the width or height, an error that indicates a transcoding failure is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCheckResoFail")]
                [Validation(Required=false)]
                public string IsCheckResoFail { get; set; }

                /// <summary>
                /// <para>Indicates whether the video bitrate is checked.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The video bitrate is checked.</description></item>
                /// <item><description><b>false</b>: The video bitrate is not checked.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If this feature is enabled and the system detects that the video bitrate of the output file is greater than that of the input file, the video bitrate of the input file is retained after transcoding.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCheckVideoBitrate")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrate { get; set; }

                /// <summary>
                /// <para>Indicates whether the video bitrate is checked. If this feature is enabled and the system detects that the video bitrate of the output file is higher than that of the input file, the input file is not transcoded. This parameter has a higher priority than the IsCheckVideoBitrate parameter.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The video bitrate is checked. In this case, if the video bitrate of the output file is higher than that of the input file, the input file is not transcoded.</description></item>
                /// <item><description><b>false</b>: The video bitrate is not checked.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCheckVideoBitrateFail")]
                [Validation(Required=false)]
                public string IsCheckVideoBitrateFail { get; set; }

                /// <summary>
                /// <para>The transcoding mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>onepass</b></description></item>
                /// <item><description><b>twopass</b></description></item>
                /// <item><description><b>CBR</b></description></item>
                /// <item><description>Default value: <b>onepass</b>.</description></item>
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
            /// <para>The video codec configurations.</para>
            /// </summary>
            [NameInMap("Video")]
            [Validation(Required=false)]
            public AddTemplateResponseBodyTemplateVideo Video { get; set; }
            public class AddTemplateResponseBodyTemplateVideo : TeaModel {
                /// <summary>
                /// <para>The bitrate of the output video. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// <para>The bitrate range of the video.</para>
                /// </summary>
                [NameInMap("BitrateBnd")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateVideoBitrateBnd BitrateBnd { get; set; }
                public class AddTemplateResponseBodyTemplateVideoBitrateBnd : TeaModel {
                    /// <summary>
                    /// <para>The maximum bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1500</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public string Max { get; set; }

                    /// <summary>
                    /// <para>The minimum bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>800</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public string Min { get; set; }

                }

                /// <summary>
                /// <para>The size of the buffer.</para>
                /// <list type="bullet">
                /// <item><description>Default value: <b>6000</b>.</description></item>
                /// <item><description>Unit: KB.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>6000</para>
                /// </summary>
                [NameInMap("Bufsize")]
                [Validation(Required=false)]
                public string Bufsize { get; set; }

                /// <summary>
                /// <para>The video codec. Valid values: H.264, H.265, GIF, and WebP. Default value: <b>H.264</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H.264</para>
                /// </summary>
                [NameInMap("Codec")]
                [Validation(Required=false)]
                public string Codec { get; set; }

                /// <summary>
                /// <para>The constant rate factor. Default value if the video codec is set to H.264: <b>23</b>. Default value if the video codec is set to H.265: <b>26</b>.</para>
                /// <remarks>
                /// <para>If this parameter is specified, the setting of the Bitrate parameter becomes invalid.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Crf")]
                [Validation(Required=false)]
                public string Crf { get; set; }

                /// <summary>
                /// <para>The method of video cropping. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>border</b>: automatically detects and removes borders.</description></item>
                /// <item><description><b>Value in the format of width:height:left:top</b>: crops the video image based on the custom settings. Example: 1280:800:0:140.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>border</para>
                /// </summary>
                [NameInMap("Crop")]
                [Validation(Required=false)]
                public string Crop { get; set; }

                /// <summary>
                /// <para>The level of quality control on the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Degrain")]
                [Validation(Required=false)]
                public string Degrain { get; set; }

                /// <summary>
                /// <para>The frame rate. Default value: the frame rate of the input file. The value is 60 if the frame rate of the input file exceeds 60. Unit: frames per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// <para>The GOP size. The GOP size can be the maximum interval of keyframes or the maximum number of frames in a frame group. If the maximum interval is specified, the value contains the unit (s). If the maximum number of frames is specified, the value does not contain a unit. Default value: <b>10s</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10s</para>
                /// </summary>
                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                /// <summary>
                /// <para>Indicates whether the HDR2SDR conversion feature is enabled. If this feature is enabled, high dynamic range (HDR) videos are transcoded to standard dynamic range (SDR) videos.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Hdr2sdr")]
                [Validation(Required=false)]
                public string Hdr2sdr { get; set; }

                /// <summary>
                /// <para>The height of the video.</para>
                /// <list type="bullet">
                /// <item><description>Unit: pixel.</description></item>
                /// <item><description>Default value: the height of the input video.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>Indicates whether the auto-rotate screen feature is enabled. Default value: <b>false</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The auto-rotate screen feature is enabled.</description></item>
                /// <item><description><b>false</b>: The auto-rotate screen feature is disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If this feature is enabled, the width of the output video corresponds to the long side of the input video, which is the height of the input video in portrait mode. The height of the output video corresponds to the short side of the input video, which is the width of the input video in portrait mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LongShortMode")]
                [Validation(Required=false)]
                public string LongShortMode { get; set; }

                /// <summary>
                /// <para>The maximum frame rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("MaxFps")]
                [Validation(Required=false)]
                public string MaxFps { get; set; }

                /// <summary>
                /// <para>The maximum bitrate of the video. Unit: Kbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Maxrate")]
                [Validation(Required=false)]
                public string Maxrate { get; set; }

                /// <summary>
                /// <para>The Narrowband HD settings.</para>
                /// </summary>
                [NameInMap("NarrowBand")]
                [Validation(Required=false)]
                public AddTemplateResponseBodyTemplateVideoNarrowBand NarrowBand { get; set; }
                public class AddTemplateResponseBodyTemplateVideoNarrowBand : TeaModel {
                    /// <summary>
                    /// <para>The upper limit of the dynamic bitrate. If this parameter is set, the average bitrate is in the range of (0, 1000000].</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("Abrmax")]
                    [Validation(Required=false)]
                    public float? Abrmax { get; set; }

                    /// <summary>
                    /// <para>The maximum ratio of the upper limit of dynamic bitrate. If this parameter is set, the value of Abrmax does not exceed x times of the source video bitrate. Valid values: (0,1.0].</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("MaxAbrRatio")]
                    [Validation(Required=false)]
                    public float? MaxAbrRatio { get; set; }

                    /// <summary>
                    /// <para>The Narrowband HD version. Only 1.0 may be returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The black borders to be added to the video. The value is in the width:height:left:top format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280:800:0:140</para>
                /// </summary>
                [NameInMap("Pad")]
                [Validation(Required=false)]
                public string Pad { get; set; }

                /// <summary>
                /// <para>The pixel format. Standard pixel formats such as yuv420p and yuvj420p are supported. The default pixel format can be <b>yuv420p</b> or the pixel format of the input video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yuv420p</para>
                /// </summary>
                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                /// <summary>
                /// <para>The preset video algorithm. Default value: <b>medium</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>veryfast</b></description></item>
                /// <item><description><b>fast</b></description></item>
                /// <item><description><b>medium</b></description></item>
                /// <item><description><b>slow</b></description></item>
                /// <item><description><b>slower</b></description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is valid only if the Codec parameter is set to H.264.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>fast</para>
                /// </summary>
                [NameInMap("Preset")]
                [Validation(Required=false)]
                public string Preset { get; set; }

                /// <summary>
                /// <para>The codec profile.</para>
                /// <list type="bullet">
                /// <item><description><b>baseline</b>: suitable for mobile devices</description></item>
                /// <item><description><b>main</b>: suitable for standard-definition devices</description></item>
                /// <item><description><b>high</b>: suitable for high-definition devices</description></item>
                /// <item><description>Default value: <b>high</b>.</description></item>
                /// </list>
                /// <para>If multiple definitions are available, we recommend that you set this parameter to baseline for the lowest definition to ensure normal playback on low-end devices. Set this parameter to main or high for other definitions.</para>
                /// <remarks>
                /// <para>This parameter is valid only if the Codec parameter is set to H.264.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The level of the independent denoising algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Qscale")]
                [Validation(Required=false)]
                public string Qscale { get; set; }

                /// <summary>
                /// <para>Indicates whether the video stream is deleted.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The video stream is deleted.</description></item>
                /// <item><description><b>false</b>: The video stream is retained.</description></item>
                /// <item><description>Default value: <b>false</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Remove")]
                [Validation(Required=false)]
                public string Remove { get; set; }

                /// <summary>
                /// <para>The policy of resolution adjustment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ResoPriority")]
                [Validation(Required=false)]
                public string ResoPriority { get; set; }

                /// <summary>
                /// <para>The scan mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>interlaced</b></description></item>
                /// <item><description><b>progressive</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>interlaced</para>
                /// </summary>
                [NameInMap("ScanMode")]
                [Validation(Required=false)]
                public string ScanMode { get; set; }

                /// <summary>
                /// <para>The width of the video.</para>
                /// <list type="bullet">
                /// <item><description>Default value: the width of the input video.****</description></item>
                /// <item><description>Unit: pixel.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

        }

    }

}
