// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC860F04-778A-472F-AB39-E1BF329C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The transcoding templates.</para>
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
                /// <para>The audio codec configurations.</para>
                /// </summary>
                [NameInMap("Audio")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateAudio Audio { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateAudio : TeaModel {
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
                    /// <para>The codec profile of the audio. Valid values when the value of Codec is aac:</para>
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
                    /// <para>The strength of the independent denoising algorithm. Valid values: <b>[1,9]</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Qscale")]
                    [Validation(Required=false)]
                    public string Qscale { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the audio stream is deleted. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
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
                    /// <para>The sampling rate.</para>
                    /// <list type="bullet">
                    /// <item><description>Unit: Hz</description></item>
                    /// <item><description>Default value: <b>44100</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("Samplerate")]
                    [Validation(Required=false)]
                    public string Samplerate { get; set; }

                }

                /// <summary>
                /// <para>The container format configurations.</para>
                /// </summary>
                [NameInMap("Container")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateContainer Container { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateContainer : TeaModel {
                    /// <summary>
                    /// <para>The format of the container. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>flv</b></description></item>
                    /// <item><description><b>mp4</b></description></item>
                    /// <item><description><b>ts</b></description></item>
                    /// <item><description><b>m3u8</b></description></item>
                    /// <item><description><b>gif</b></description></item>
                    /// <item><description><b>mp3</b></description></item>
                    /// <item><description><b>ogg</b></description></item>
                    /// <item><description><b>flac</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mp4</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                }

                /// <summary>
                /// <para>The time when the template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-04T06:44:43Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The transcoding template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16f01ad6175e4230ac42bb5182cd****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The transmuxing configurations.</para>
                /// </summary>
                [NameInMap("MuxConfig")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateMuxConfig MuxConfig { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateMuxConfig : TeaModel {
                    /// <summary>
                    /// <para>The transmuxing configurations for GIF.</para>
                    /// </summary>
                    [NameInMap("Gif")]
                    [Validation(Required=false)]
                    public SearchTemplateResponseBodyTemplateListTemplateMuxConfigGif Gif { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateMuxConfigGif : TeaModel {
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
                        /// <para>The duration for which the final frame is paused. Unit: centisecond.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("FinalDelay")]
                        [Validation(Required=false)]
                        public string FinalDelay { get; set; }

                        /// <summary>
                        /// <para>Indicates whether a custom palette is used.</para>
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
                    /// <para>The segment configurations.</para>
                    /// </summary>
                    [NameInMap("Segment")]
                    [Validation(Required=false)]
                    public SearchTemplateResponseBodyTemplateListTemplateMuxConfigSegment Segment { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateMuxConfigSegment : TeaModel {
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

                }

                /// <summary>
                /// <para>The name of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MPS-example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>Deleted</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The general transcoding configurations.</para>
                /// </summary>
                [NameInMap("TransConfig")]
                [Validation(Required=false)]
                public SearchTemplateResponseBodyTemplateListTemplateTransConfig TransConfig { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateTransConfig : TeaModel {
                    /// <summary>
                    /// <para>The method of resolution adjustment. Default value: <b>none</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>rescale</description></item>
                    /// <item><description>crop</description></item>
                    /// <item><description>none</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("AdjDarMethod")]
                    [Validation(Required=false)]
                    public string AdjDarMethod { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the audio bitrate is checked. If the bitrate of the output audio is higher than that of the input audio, the input bitrate is retained and the specified audio bitrate does not take effect. This parameter has a lower priority than IsCheckAudioBitrateFail. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>true</b></para>
                    /// </description></item>
                    /// <item><description><para><b>false</b></para>
                    /// </description></item>
                    /// <item><description><para>Default value:</para>
                    /// <list type="bullet">
                    /// <item><description>If this parameter is empty and the codec of the output audio is different from that of the input audio, the default value is false.</description></item>
                    /// <item><description>If this parameter is empty and the codec of the output audio is the same as that of the input audio, the default value is true.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCheckAudioBitrate")]
                    [Validation(Required=false)]
                    public string IsCheckAudioBitrate { get; set; }

                    /// <summary>
                    /// <para>Indicates whether audio bitrate check errors are allowed. This parameter has a greater priority than IsCheckAudioBitrate. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: If the audio bitrate check fails, the input file is not transcoded.</description></item>
                    /// <item><description><b>false</b>: The audio bitrate is not checked.</description></item>
                    /// <item><description>Default value: <b>false</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCheckAudioBitrateFail")]
                    [Validation(Required=false)]
                    public string IsCheckAudioBitrateFail { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, the input resolution is retained. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// <item><description>Default value: <b>false</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCheckReso")]
                    [Validation(Required=false)]
                    public string IsCheckReso { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the resolution is checked. If the output resolution is higher than the input resolution based on the width or height, a transcoding failure is returned. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// <item><description>Default value: <b>false</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCheckResoFail")]
                    [Validation(Required=false)]
                    public string IsCheckResoFail { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the video bitrate is checked. If the bitrate of the output video is higher than that of the input video, the input bitrate is retained. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// <item><description>Default value: <b>false</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCheckVideoBitrate")]
                    [Validation(Required=false)]
                    public string IsCheckVideoBitrate { get; set; }

                    /// <summary>
                    /// <para>Indicates whether video bitrate check errors are allowed. This parameter has a higher priority than IsCheckVideoBitrate. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: If the video bitrate check fails, the input file is not transcoded.</description></item>
                    /// <item><description><b>false</b>: The video bitrate is not checked.</description></item>
                    /// <item><description>Default value: <b>false</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCheckVideoBitrateFail")]
                    [Validation(Required=false)]
                    public string IsCheckVideoBitrateFail { get; set; }

                    /// <summary>
                    /// <para>The transcoding mode. Default value: <b>onepass</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>onepass</b></description></item>
                    /// <item><description><b>twopass</b></description></item>
                    /// <item><description><b>CBR</b></description></item>
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
                public SearchTemplateResponseBodyTemplateListTemplateVideo Video { get; set; }
                public class SearchTemplateResponseBodyTemplateListTemplateVideo : TeaModel {
                    /// <summary>
                    /// <para>The average bitrate of the video. Unit: Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The average bitrate range of the video.</para>
                    /// </summary>
                    [NameInMap("BitrateBnd")]
                    [Validation(Required=false)]
                    public SearchTemplateResponseBodyTemplateListTemplateVideoBitrateBnd BitrateBnd { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateVideoBitrateBnd : TeaModel {
                        /// <summary>
                        /// <para>The upper limit of the total bitrate. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>500</para>
                        /// </summary>
                        [NameInMap("Max")]
                        [Validation(Required=false)]
                        public string Max { get; set; }

                        /// <summary>
                        /// <para>The lower limit of the total bitrate. Unit: Kbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Min")]
                        [Validation(Required=false)]
                        public string Min { get; set; }

                    }

                    /// <summary>
                    /// <para>The buffer size.</para>
                    /// <list type="bullet">
                    /// <item><description>Unit: KB.</description></item>
                    /// <item><description>Default value: <b>6000</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6000</para>
                    /// </summary>
                    [NameInMap("Bufsize")]
                    [Validation(Required=false)]
                    public string Bufsize { get; set; }

                    /// <summary>
                    /// <para>The codec.</para>
                    /// <list type="bullet">
                    /// <item><description>Valid values: H.264 and H.265.</description></item>
                    /// <item><description>Default value: <b>H.264</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>H.264</para>
                    /// </summary>
                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    /// <summary>
                    /// <para>The constant rate factor.</para>
                    /// <list type="bullet">
                    /// <item><description>Default value when the value of Codec is H.264: <b>23</b>, default value when the value of Codec is H.265: <b>26</b>.</description></item>
                    /// <item><description>If this parameter is set, the value of Bitrate becomes invalid.</description></item>
                    /// </list>
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
                    /// <item><description><b>border</b>: automatically detects and removes black bars.</description></item>
                    /// <item><description><b>Value in the width:height:left:top format</b>: crops the video image based on the custom settings. Format: width:height:left:top. Example: 1280:800:0:140.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>border</para>
                    /// </summary>
                    [NameInMap("Crop")]
                    [Validation(Required=false)]
                    public string Crop { get; set; }

                    /// <summary>
                    /// <para>The level of video quality control.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Degrain")]
                    [Validation(Required=false)]
                    public string Degrain { get; set; }

                    /// <summary>
                    /// <para>The frame rate of the video.</para>
                    /// <list type="bullet">
                    /// <item><description>The value is 60 if the frame rate of the input video exceeds 60.</description></item>
                    /// <item><description>Default value: <b>the frame rate of the input video</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("Fps")]
                    [Validation(Required=false)]
                    public string Fps { get; set; }

                    /// <summary>
                    /// <para>The maximum number of frames between two keyframes. Default value: <b>250</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
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
                    /// <item><description>Default value: <b>the height of the input video</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>800</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the auto-rotate screen feature is enabled.</para>
                    /// <list type="bullet">
                    /// <item><description>If this feature is enabled, the width of the output video corresponds to the long side of the input video, which is the height of the input video in portrait mode. The height of the output video corresponds to the short side of the input video, which is the width of the input video in portrait mode. Valid values:</description></item>
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// <item><description>Default value: <b>false</b>.</description></item>
                    /// </list>
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
                    public SearchTemplateResponseBodyTemplateListTemplateVideoNarrowBand NarrowBand { get; set; }
                    public class SearchTemplateResponseBodyTemplateListTemplateVideoNarrowBand : TeaModel {
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
                    /// <para>The black bars that are added to the video.</para>
                    /// <list type="bullet">
                    /// <item><description>Format: width:height:left:top.</description></item>
                    /// <item><description>Example: 1280:800:0:140.</description></item>
                    /// </list>
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
                    /// <para>The preset video algorithm. Default value: <b>medium</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>veryfast</b></description></item>
                    /// <item><description><b>fast</b></description></item>
                    /// <item><description><b>medium</b></description></item>
                    /// <item><description><b>slow</b></description></item>
                    /// <item><description><b>slower</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>medium</para>
                    /// </summary>
                    [NameInMap("Preset")]
                    [Validation(Required=false)]
                    public string Preset { get; set; }

                    /// <summary>
                    /// <para>The codec profile. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>baseline</b>: applicable to mobile devices.</description></item>
                    /// <item><description><b>main</b>: applicable to standard-definition devices.</description></item>
                    /// <item><description><b>high</b>: applicable to high-definition devices.</description></item>
                    /// <item><description>Default value: <b>high</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <para>The strength of the independent denoising algorithm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Qscale")]
                    [Validation(Required=false)]
                    public string Qscale { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the video stream is deleted. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
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
                    /// <para>heightFirst</para>
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
                    /// <item><description>Valid values: <b>[128,4096]</b>.</description></item>
                    /// <item><description>Unit: pixel.</description></item>
                    /// <item><description>Default value: <b>the width of the input video</b>.</description></item>
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

        /// <summary>
        /// <para>The total number of search results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
