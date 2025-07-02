// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateMediaLiveChannelRequest : TeaModel {
        /// <summary>
        /// <para>The audio settings.</para>
        /// </summary>
        [NameInMap("AudioSettings")]
        [Validation(Required=false)]
        public List<CreateMediaLiveChannelRequestAudioSettings> AudioSettings { get; set; }
        public class CreateMediaLiveChannelRequestAudioSettings : TeaModel {
            /// <summary>
            /// <para>The audio codec. If it is not specified, the source specification is used. Valid values: aac and libfdk_aac.</para>
            /// 
            /// <b>Example:</b>
            /// <para>libfdk_aac</para>
            /// </summary>
            [NameInMap("AudioCodec")]
            [Validation(Required=false)]
            public string AudioCodec { get; set; }

            /// <summary>
            /// <para>The audio encoding settings.</para>
            /// </summary>
            [NameInMap("AudioCodecSetting")]
            [Validation(Required=false)]
            public CreateMediaLiveChannelRequestAudioSettingsAudioCodecSetting AudioCodecSetting { get; set; }
            public class CreateMediaLiveChannelRequestAudioSettingsAudioCodecSetting : TeaModel {
                /// <summary>
                /// <para>The audio bitrate. Unit: bit/s. Valid values: 8000 to 1000000. The value must be divisible by 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200000</para>
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public int? Bitrate { get; set; }

                /// <summary>
                /// <para>The audio codec profile. When AudioCodec is set to aac, AAC-LOW and AAC-MAIN are supported. When AudioCodec is set to libfdk_aac, AAC-LOW, AAC-HE, and AAC-HEV2 are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AAC-LOW</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// <para>The audio sample rate. Unit: Hz. Valid values: 22050, 32000, 44100, 48000, and 96000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44100</para>
                /// </summary>
                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public int? SampleRate { get; set; }

            }

            /// <summary>
            /// <para>The name of the audio selector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a1</para>
            /// </summary>
            [NameInMap("AudioSelectorName")]
            [Validation(Required=false)]
            public string AudioSelectorName { get; set; }

            /// <summary>
            /// <para>Enter a three-letter ISO 639-2 language code. If the audio track selected by the audio selector has a language code, the language code specified in the audio selector is used. If the selected audio track does not have a language code, or if the audio selector cannot find a track that matches its criteria, this language code is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eng</para>
            /// </summary>
            [NameInMap("LanguageCode")]
            [Validation(Required=false)]
            public string LanguageCode { get; set; }

            /// <summary>
            /// <para>The tag that identifies the language of the RTMP input. It can be referenced by the output. The maximum length is 32 characters. Supported characters:</para>
            /// <list type="bullet">
            /// <item><description>Unicode letters</description></item>
            /// <item><description>Digits (0-9)</description></item>
            /// <item><description>Underscore (_)</description></item>
            /// <item><description>Hyphen (-)</description></item>
            /// <item><description>Space (a space cannot be at the beginning or end)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>English</para>
            /// </summary>
            [NameInMap("LanguageName")]
            [Validation(Required=false)]
            public string LanguageName { get; set; }

            /// <summary>
            /// <para>The name of the audio settings. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The associated inputs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputAttachments")]
        [Validation(Required=false)]
        public List<CreateMediaLiveChannelRequestInputAttachments> InputAttachments { get; set; }
        public class CreateMediaLiveChannelRequestInputAttachments : TeaModel {
            /// <summary>
            /// <para>The audio selectors.</para>
            /// </summary>
            [NameInMap("AudioSelectors")]
            [Validation(Required=false)]
            public List<CreateMediaLiveChannelRequestInputAttachmentsAudioSelectors> AudioSelectors { get; set; }
            public class CreateMediaLiveChannelRequestInputAttachmentsAudioSelectors : TeaModel {
                /// <summary>
                /// <para>The audio language selection.</para>
                /// </summary>
                [NameInMap("AudioLanguageSelection")]
                [Validation(Required=false)]
                public CreateMediaLiveChannelRequestInputAttachmentsAudioSelectorsAudioLanguageSelection AudioLanguageSelection { get; set; }
                public class CreateMediaLiveChannelRequestInputAttachmentsAudioSelectorsAudioLanguageSelection : TeaModel {
                    /// <summary>
                    /// <para>Enter a three-letter ISO 639-2 language code from within an audio source.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eng</para>
                    /// </summary>
                    [NameInMap("LanguageCode")]
                    [Validation(Required=false)]
                    public string LanguageCode { get; set; }

                }

                /// <summary>
                /// <para>The audio PID selection.</para>
                /// </summary>
                [NameInMap("AudioPidSelection")]
                [Validation(Required=false)]
                public CreateMediaLiveChannelRequestInputAttachmentsAudioSelectorsAudioPidSelection AudioPidSelection { get; set; }
                public class CreateMediaLiveChannelRequestInputAttachmentsAudioSelectorsAudioPidSelection : TeaModel {
                    /// <summary>
                    /// <para>Enter a specific PID from within a source.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Pid")]
                    [Validation(Required=false)]
                    public long? Pid { get; set; }

                }

                /// <summary>
                /// <para>The audio track selection.</para>
                /// </summary>
                [NameInMap("AudioTrackSelection")]
                [Validation(Required=false)]
                public List<CreateMediaLiveChannelRequestInputAttachmentsAudioSelectorsAudioTrackSelection> AudioTrackSelection { get; set; }
                public class CreateMediaLiveChannelRequestInputAttachmentsAudioSelectorsAudioTrackSelection : TeaModel {
                    /// <summary>
                    /// <para>Specify one or more audio tracks from within a source using Track ID.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TrackId")]
                    [Validation(Required=false)]
                    public long? TrackId { get; set; }

                }

                /// <summary>
                /// <para>The name of the audio selector. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myselector</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The ID of the associated input.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myinput</para>
            /// </summary>
            [NameInMap("InputId")]
            [Validation(Required=false)]
            public string InputId { get; set; }

            /// <summary>
            /// <para>The tag that identifies the language of the RTMP input. It can be referenced by the output. The maximum length is 32 characters. Supported characters:</para>
            /// <list type="bullet">
            /// <item><description>Unicode letters</description></item>
            /// <item><description>Digits (0-9)</description></item>
            /// <item><description>Underscore (_)</description></item>
            /// <item><description>Hyphen (-)</description></item>
            /// <item><description>Space (a space cannot be at the beginning or end)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>English</para>
            /// </summary>
            [NameInMap("LanguageName")]
            [Validation(Required=false)]
            public string LanguageName { get; set; }

        }

        /// <summary>
        /// <para>The name of the channel. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mych</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputGroups")]
        [Validation(Required=false)]
        public List<CreateMediaLiveChannelRequestOutputGroups> OutputGroups { get; set; }
        public class CreateMediaLiveChannelRequestOutputGroups : TeaModel {
            /// <summary>
            /// <para>The MediaPackage destination.</para>
            /// </summary>
            [NameInMap("MediaPackageGroupSetting")]
            [Validation(Required=false)]
            public CreateMediaLiveChannelRequestOutputGroupsMediaPackageGroupSetting MediaPackageGroupSetting { get; set; }
            public class CreateMediaLiveChannelRequestOutputGroupsMediaPackageGroupSetting : TeaModel {
                /// <summary>
                /// <para>ChannelName in MediaPackage.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myPackageChannel</para>
                /// </summary>
                [NameInMap("ChannelName")]
                [Validation(Required=false)]
                public string ChannelName { get; set; }

                /// <summary>
                /// <para>GroupName in MediaPackage.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myPackageGroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The name of the output group. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The outputs in the output group.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<CreateMediaLiveChannelRequestOutputGroupsOutputs> Outputs { get; set; }
            public class CreateMediaLiveChannelRequestOutputGroupsOutputs : TeaModel {
                /// <summary>
                /// <para>The referenced AudioSettings.</para>
                /// </summary>
                [NameInMap("AudioSettingNames")]
                [Validation(Required=false)]
                public List<string> AudioSettingNames { get; set; }

                /// <summary>
                /// <para>The settings of the output delivered to MediaPackage.</para>
                /// </summary>
                [NameInMap("MediaPackageOutputSetting")]
                [Validation(Required=false)]
                public CreateMediaLiveChannelRequestOutputGroupsOutputsMediaPackageOutputSetting MediaPackageOutputSetting { get; set; }
                public class CreateMediaLiveChannelRequestOutputGroupsOutputsMediaPackageOutputSetting : TeaModel {
                    /// <summary>
                    /// <para>The manifest audio group ID. To associate several audio tracks into one group, assign the same audio group ID. Viewers can select a track as needed. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 40 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>audiogroup</para>
                    /// </summary>
                    [NameInMap("AudioGroupId")]
                    [Validation(Required=false)]
                    public string AudioGroupId { get; set; }

                    /// <summary>
                    /// <para>The manifest name modifier. The child manifests include this modifier in their M3U8 file names. Letters, digits, hyphens (-), and underscores (_) are supported. The maximum length is 40 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>480p</para>
                    /// </summary>
                    [NameInMap("NameModifier")]
                    [Validation(Required=false)]
                    public string NameModifier { get; set; }

                }

                /// <summary>
                /// <para>The media type of the output. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Audio and Video.</description></item>
                /// <item><description>1: Audio. If you set the value to 1, you cannot reference VideoSettings.</description></item>
                /// <item><description>2: Video. If you set the value to 2, you cannot reference AudioSettings.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public int? MediaType { get; set; }

                /// <summary>
                /// <para>The name of the output. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>output1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The name of the referenced VideoSettings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myVideo1</para>
                /// </summary>
                [NameInMap("VideoSettingName")]
                [Validation(Required=false)]
                public string VideoSettingName { get; set; }

            }

            /// <summary>
            /// <para>The output group type. Only MediaPackage is supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MediaPackage</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The video settings.</para>
        /// </summary>
        [NameInMap("VideoSettings")]
        [Validation(Required=false)]
        public List<CreateMediaLiveChannelRequestVideoSettings> VideoSettings { get; set; }
        public class CreateMediaLiveChannelRequestVideoSettings : TeaModel {
            /// <summary>
            /// <para>The height of the output. If you set it to 0 or leave it empty, the height automatically adapts to the specified width to maintain the original aspect ratio.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>For regular transcoding, the larger dimension cannot exceed 3840 px, and the smaller one cannot exceed 2160 px.</description></item>
            /// <item><description>For Narrowband HD™ transcoding, the larger dimension cannot exceed 1920 px, and the smaller one cannot exceed 1080 px.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>The name of the video settings. Letters, digits, hyphens (-), and underscores (_) are supported. It can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The video codec. Valid values: H264 and H265.</para>
            /// 
            /// <b>Example:</b>
            /// <para>H264</para>
            /// </summary>
            [NameInMap("VideoCodec")]
            [Validation(Required=false)]
            public string VideoCodec { get; set; }

            /// <summary>
            /// <para>The video encoding settings.</para>
            /// </summary>
            [NameInMap("VideoCodecSetting")]
            [Validation(Required=false)]
            public CreateMediaLiveChannelRequestVideoSettingsVideoCodecSetting VideoCodecSetting { get; set; }
            public class CreateMediaLiveChannelRequestVideoSettingsVideoCodecSetting : TeaModel {
                /// <summary>
                /// <para>The video encoding settings.</para>
                /// </summary>
                [NameInMap("CodecDetail")]
                [Validation(Required=false)]
                public CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingCodecDetail CodecDetail { get; set; }
                public class CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingCodecDetail : TeaModel {
                    /// <summary>
                    /// <para>The video encoding level. It is not supported yet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>H264_LEVEL_AUTO</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The H.264 profile. Valid values: BASELINE, HIGH, and MAIN. Default value: MAIN. The parameter takes effect only when the codec is H.264.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAIN</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                }

                /// <summary>
                /// <para>The frame rate. If it is not specified, the source specification is used.</para>
                /// </summary>
                [NameInMap("Framerate")]
                [Validation(Required=false)]
                public CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingFramerate Framerate { get; set; }
                public class CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingFramerate : TeaModel {
                    /// <summary>
                    /// <para>The frame rate mode. Valid values: SPECIFIED (fixed frame rate) and FROM_SOURCE (use source specification).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SPECIFIED</para>
                    /// </summary>
                    [NameInMap("FramerateControl")]
                    [Validation(Required=false)]
                    public string FramerateControl { get; set; }

                    /// <summary>
                    /// <para>The denominator of the fixed frame rate. The parameter is required when FramerateControl is set to SPECIFIED. Valid values: 1 to 60. The numerator must be divisible by the denominator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FramerateDenominator")]
                    [Validation(Required=false)]
                    public int? FramerateDenominator { get; set; }

                    /// <summary>
                    /// <para>The numerator of the fixed frame rate. The parameter is required when FramerateControl is set to SPECIFIED. Valid values: 1 to 60. The numerator must be divisible by the denominator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("FramerateNumerator")]
                    [Validation(Required=false)]
                    public int? FramerateNumerator { get; set; }

                }

                /// <summary>
                /// <para>The GOP setting. If it is not specified, the source specification is used.</para>
                /// </summary>
                [NameInMap("Gop")]
                [Validation(Required=false)]
                public CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingGop Gop { get; set; }
                public class CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingGop : TeaModel {
                    /// <summary>
                    /// <para>The number of B frames. Valid values: 1 to 3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("BframesNum")]
                    [Validation(Required=false)]
                    public int? BframesNum { get; set; }

                    /// <summary>
                    /// <para>The GOP size. When GopSizeUnits is set to SECONDS, the value range is from 1 to 20. When GopSizeUnits is set to FRAMES, the value range is from 1 to 3000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("GopSize")]
                    [Validation(Required=false)]
                    public int? GopSize { get; set; }

                    /// <summary>
                    /// <para>The GOP size unit. Valid values: FRAMES and SECONDS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FRAMES</para>
                    /// </summary>
                    [NameInMap("GopSizeUnits")]
                    [Validation(Required=false)]
                    public string GopSizeUnits { get; set; }

                }

                /// <summary>
                /// <para>The video encoding rate. If it is not specified, the source specification is used.</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingRate Rate { get; set; }
                public class CreateMediaLiveChannelRequestVideoSettingsVideoCodecSettingRate : TeaModel {
                    /// <summary>
                    /// <para>The video bitrate. Unit: bit/s. If you set it to 0 or leave it empty, the source specification is used. Valid values: 50000 to 6000000. The value must be divisible by 1000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2500000</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public int? Bitrate { get; set; }

                    /// <summary>
                    /// <para>The video buffer size. Unit: bit/s. Valid values: 100000 to 6000000. The value must be divisible by 1000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6000000</para>
                    /// </summary>
                    [NameInMap("BufferSize")]
                    [Validation(Required=false)]
                    public int? BufferSize { get; set; }

                    /// <summary>
                    /// <para>The maximum bitrate. Unit: bit/s. Valid values: 100000 to 6000000. The value must be divisible by 1000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6000000</para>
                    /// </summary>
                    [NameInMap("MaxBitrate")]
                    [Validation(Required=false)]
                    public int? MaxBitrate { get; set; }

                    /// <summary>
                    /// <para>The bitrate control mode. Valid values: CBR, ABR, and VBR.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ABR</para>
                    /// </summary>
                    [NameInMap("RateControlMode")]
                    [Validation(Required=false)]
                    public string RateControlMode { get; set; }

                }

            }

            /// <summary>
            /// <para>The video transcoding method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: regular transcoding</description></item>
            /// <item><description>NBHD: Narrowband HD™ transcoding</description></item>
            /// </list>
            /// <para>If not specified, regular transcoding is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("VideoCodecType")]
            [Validation(Required=false)]
            public string VideoCodecType { get; set; }

            /// <summary>
            /// <para>The width of the output. If you set it to 0 or leave it empty, the width automatically adapts to the specified height to maintain the original aspect ratio.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>For regular transcoding, the larger dimension cannot exceed 3840 px, and the smaller one cannot exceed 2160 px.</description></item>
            /// <item><description>For Narrowband HD™ transcoding, the larger dimension cannot exceed 1920 px, and the smaller one cannot exceed 1080 px.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

    }

}
