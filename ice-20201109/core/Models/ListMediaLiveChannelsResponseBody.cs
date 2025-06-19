// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaLiveChannelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The channels.</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<ListMediaLiveChannelsResponseBodyChannels> Channels { get; set; }
        public class ListMediaLiveChannelsResponseBodyChannels : TeaModel {
            /// <summary>
            /// <para>The audio settings.</para>
            /// </summary>
            [NameInMap("AudioSettings")]
            [Validation(Required=false)]
            public List<ListMediaLiveChannelsResponseBodyChannelsAudioSettings> AudioSettings { get; set; }
            public class ListMediaLiveChannelsResponseBodyChannelsAudioSettings : TeaModel {
                /// <summary>
                /// <para>The audio codec.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aac</para>
                /// </summary>
                [NameInMap("AudioCodec")]
                [Validation(Required=false)]
                public string AudioCodec { get; set; }

                /// <summary>
                /// <para>The audio encoding settings.</para>
                /// </summary>
                [NameInMap("AudioCodecSetting")]
                [Validation(Required=false)]
                public ListMediaLiveChannelsResponseBodyChannelsAudioSettingsAudioCodecSetting AudioCodecSetting { get; set; }
                public class ListMediaLiveChannelsResponseBodyChannelsAudioSettingsAudioCodecSetting : TeaModel {
                    /// <summary>
                    /// <para>The audio bitrate. Unit: bit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200000</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public int? Bitrate { get; set; }

                    /// <summary>
                    /// <para>The audio codec profile.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AAC-LOW</para>
                    /// </summary>
                    [NameInMap("Profile")]
                    [Validation(Required=false)]
                    public string Profile { get; set; }

                    /// <summary>
                    /// <para>The audio sample rate. Unit: Hz.</para>
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
                /// <para>myselector</para>
                /// </summary>
                [NameInMap("AudioSelectorName")]
                [Validation(Required=false)]
                public string AudioSelectorName { get; set; }

                /// <summary>
                /// <para>A three-letter ISO 639-2 language code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eng</para>
                /// </summary>
                [NameInMap("LanguageCode")]
                [Validation(Required=false)]
                public string LanguageCode { get; set; }

                /// <summary>
                /// <para>The name of the language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>English</para>
                /// </summary>
                [NameInMap("LanguageName")]
                [Validation(Required=false)]
                public string LanguageName { get; set; }

                /// <summary>
                /// <para>The name of the audio settings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhuanfengzhuang</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The ID of the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SEGK5KA6KYKAWQQH</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The time when the channel was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-03T06:56:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The inputs associated with the channel.</para>
            /// </summary>
            [NameInMap("InputAttachments")]
            [Validation(Required=false)]
            public List<ListMediaLiveChannelsResponseBodyChannelsInputAttachments> InputAttachments { get; set; }
            public class ListMediaLiveChannelsResponseBodyChannelsInputAttachments : TeaModel {
                /// <summary>
                /// <para>The audio selectors.</para>
                /// </summary>
                [NameInMap("AudioSelectors")]
                [Validation(Required=false)]
                public List<ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectors> AudioSelectors { get; set; }
                public class ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectors : TeaModel {
                    /// <summary>
                    /// <para>The audio language selection.</para>
                    /// </summary>
                    [NameInMap("AudioLanguageSelection")]
                    [Validation(Required=false)]
                    public ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectorsAudioLanguageSelection AudioLanguageSelection { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectorsAudioLanguageSelection : TeaModel {
                        /// <summary>
                        /// <para>A three-letter ISO 639-2 language code from within an audio source.</para>
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
                    public ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectorsAudioPidSelection AudioPidSelection { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectorsAudioPidSelection : TeaModel {
                        /// <summary>
                        /// <para>A PID from within a source.</para>
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
                    public List<ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectorsAudioTrackSelection> AudioTrackSelection { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsInputAttachmentsAudioSelectorsAudioTrackSelection : TeaModel {
                        /// <summary>
                        /// <para>The track ID from within a source.</para>
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
                    /// <para>The name of the audio selector.</para>
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
                /// <para>The ID of the input.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SEGK5KA6KYKAWQQH</para>
                /// </summary>
                [NameInMap("InputId")]
                [Validation(Required=false)]
                public string InputId { get; set; }

                /// <summary>
                /// <para>The name of the input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myinput</para>
                /// </summary>
                [NameInMap("InputName")]
                [Validation(Required=false)]
                public string InputName { get; set; }

                /// <summary>
                /// <para>The name of the language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eng</para>
                /// </summary>
                [NameInMap("LanguageName")]
                [Validation(Required=false)]
                public string LanguageName { get; set; }

            }

            /// <summary>
            /// <para>The time when the channel was last started. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. If the channel has never been started since it was created, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-03T06:56:42Z</para>
            /// </summary>
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }

            /// <summary>
            /// <para>The time when the channel was last stopped. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. If the channel has never stopped since it was created, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-03T06:56:42Z</para>
            /// </summary>
            [NameInMap("LastStopTime")]
            [Validation(Required=false)]
            public string LastStopTime { get; set; }

            /// <summary>
            /// <para>The name of the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mych</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output groups.</para>
            /// </summary>
            [NameInMap("OutputGroups")]
            [Validation(Required=false)]
            public List<ListMediaLiveChannelsResponseBodyChannelsOutputGroups> OutputGroups { get; set; }
            public class ListMediaLiveChannelsResponseBodyChannelsOutputGroups : TeaModel {
                /// <summary>
                /// <para>The MediaPackage destination.</para>
                /// </summary>
                [NameInMap("MediaPackageGroupSetting")]
                [Validation(Required=false)]
                public ListMediaLiveChannelsResponseBodyChannelsOutputGroupsMediaPackageGroupSetting MediaPackageGroupSetting { get; set; }
                public class ListMediaLiveChannelsResponseBodyChannelsOutputGroupsMediaPackageGroupSetting : TeaModel {
                    /// <summary>
                    /// <para>ChannelName in MediaPackage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>myPackageChannel</para>
                    /// </summary>
                    [NameInMap("ChannelName")]
                    [Validation(Required=false)]
                    public string ChannelName { get; set; }

                    /// <summary>
                    /// <para>GroupName in MediaPackage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>myPackageGroup</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                }

                /// <summary>
                /// <para>The URL for monitoring the output group. The parameter is returned only when the output gourp type is MediaPackage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://xxx</para>
                /// </summary>
                [NameInMap("MonitorUrl")]
                [Validation(Required=false)]
                public string MonitorUrl { get; set; }

                /// <summary>
                /// <para>The name of the output group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outputs in the output group.</para>
                /// </summary>
                [NameInMap("Outputs")]
                [Validation(Required=false)]
                public List<ListMediaLiveChannelsResponseBodyChannelsOutputGroupsOutputs> Outputs { get; set; }
                public class ListMediaLiveChannelsResponseBodyChannelsOutputGroupsOutputs : TeaModel {
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
                    public ListMediaLiveChannelsResponseBodyChannelsOutputGroupsOutputsMediaPackageOutputSetting MediaPackageOutputSetting { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsOutputGroupsOutputsMediaPackageOutputSetting : TeaModel {
                        /// <summary>
                        /// <para>The manifest audio group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>audiogroup</para>
                        /// </summary>
                        [NameInMap("AudioGroupId")]
                        [Validation(Required=false)]
                        public string AudioGroupId { get; set; }

                        /// <summary>
                        /// <para>The manifest name modifier. The child manifests include this modifier in their M3U8 file names.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>480p</para>
                        /// </summary>
                        [NameInMap("NameModifier")]
                        [Validation(Required=false)]
                        public string NameModifier { get; set; }

                    }

                    /// <summary>
                    /// <para>The media type of the output.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public int? MediaType { get; set; }

                    /// <summary>
                    /// <para>The name of the output.</para>
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
                /// <para>The output group type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MediaPackage</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The state of the channel. Valid values: IDLE, STARTING, RUNNING, RECOVERING, and STOPPING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IDLE</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The video settings.</para>
            /// </summary>
            [NameInMap("VideoSettings")]
            [Validation(Required=false)]
            public List<ListMediaLiveChannelsResponseBodyChannelsVideoSettings> VideoSettings { get; set; }
            public class ListMediaLiveChannelsResponseBodyChannelsVideoSettings : TeaModel {
                /// <summary>
                /// <para>The height of the video in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <para>The name of the video settings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The video codec.</para>
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
                public ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSetting VideoCodecSetting { get; set; }
                public class ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSetting : TeaModel {
                    /// <summary>
                    /// <para>The video encoding settings.</para>
                    /// </summary>
                    [NameInMap("CodecDetail")]
                    [Validation(Required=false)]
                    public ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingCodecDetail CodecDetail { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingCodecDetail : TeaModel {
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
                        /// <para>The H.264 profile.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MAIN</para>
                        /// </summary>
                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                    }

                    /// <summary>
                    /// <para>The frame rate.</para>
                    /// </summary>
                    [NameInMap("Framerate")]
                    [Validation(Required=false)]
                    public ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingFramerate Framerate { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingFramerate : TeaModel {
                        /// <summary>
                        /// <para>The frame rate mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SPECIFIED</para>
                        /// </summary>
                        [NameInMap("FramerateControl")]
                        [Validation(Required=false)]
                        public string FramerateControl { get; set; }

                        /// <summary>
                        /// <para>The denominator of the fixed frame rate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("FramerateDenominator")]
                        [Validation(Required=false)]
                        public int? FramerateDenominator { get; set; }

                        /// <summary>
                        /// <para>The numerator of the fixed frame rate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>25</para>
                        /// </summary>
                        [NameInMap("FramerateNumerator")]
                        [Validation(Required=false)]
                        public int? FramerateNumerator { get; set; }

                    }

                    /// <summary>
                    /// <para>The GOP setting.</para>
                    /// </summary>
                    [NameInMap("Gop")]
                    [Validation(Required=false)]
                    public ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingGop Gop { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingGop : TeaModel {
                        /// <summary>
                        /// <para>The number of B frames.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("BframesNum")]
                        [Validation(Required=false)]
                        public int? BframesNum { get; set; }

                        /// <summary>
                        /// <para>The GOP size.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90</para>
                        /// </summary>
                        [NameInMap("GopSize")]
                        [Validation(Required=false)]
                        public int? GopSize { get; set; }

                        /// <summary>
                        /// <para>The GOP size unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FRAMES</para>
                        /// </summary>
                        [NameInMap("GopSizeUnits")]
                        [Validation(Required=false)]
                        public string GopSizeUnits { get; set; }

                    }

                    /// <summary>
                    /// <para>The video encoding rate.</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingRate Rate { get; set; }
                    public class ListMediaLiveChannelsResponseBodyChannelsVideoSettingsVideoCodecSettingRate : TeaModel {
                        /// <summary>
                        /// <para>The video bitrate. Unit: bit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2500000</para>
                        /// </summary>
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public int? Bitrate { get; set; }

                        /// <summary>
                        /// <para>The video buffer size. Unit: bit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6000000</para>
                        /// </summary>
                        [NameInMap("BufferSize")]
                        [Validation(Required=false)]
                        public int? BufferSize { get; set; }

                        /// <summary>
                        /// <para>The maximum bitrate. Unit: bit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>6000000</para>
                        /// </summary>
                        [NameInMap("MaxBitrate")]
                        [Validation(Required=false)]
                        public int? MaxBitrate { get; set; }

                        /// <summary>
                        /// <para>The bitrate control mode.</para>
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
                /// <para>The video transcoding method. Valid values: NORMAL (regular transcoding) and NBHD (Narrowband HD™ transcoding).</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("VideoCodecType")]
                [Validation(Required=false)]
                public string VideoCodecType { get; set; }

                /// <summary>
                /// <para>The width of the video in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
