// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterConfigResponseBody : TeaModel {
        [NameInMap("AudioMixerMode")]
        [Validation(Required=false)]
        public string AudioMixerMode { get; set; }

        /// <summary>
        /// <para>The automatic standby video switching configuration. <c>eofThres</c>: specifies the duration of stream interruption before automatically switching to the standby video. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;eofThres&quot;:3}</para>
        /// </summary>
        [NameInMap("AutoSwitchUrgentConfig")]
        [Validation(Required=false)]
        public string AutoSwitchUrgentConfig { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic switchover to the standby video upon stream interruption is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Shutdown.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoSwitchUrgentOn")]
        [Validation(Required=false)]
        public string AutoSwitchUrgentOn { get; set; }

        /// <summary>
        /// <para>The user callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/callBackLive">http://learn.aliyundoc.com/callBackLive</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The production studio ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The production studio name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coco-caster10</para>
        /// </summary>
        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        /// <summary>
        /// <para>Indicates whether Channel is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelEnable")]
        [Validation(Required=false)]
        public int? ChannelEnable { get; set; }

        /// <summary>
        /// <para>The stream delay. Unit: seconds. </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Stream delay is disabled.</description></item>
        /// <item><description>Greater than <b>0</b>: Stream delay is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Delay")]
        [Validation(Required=false)]
        public float? Delay { get; set; }

        /// <summary>
        /// <para>The primary streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The playlist effective flag. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not effective.</description></item>
        /// <item><description><b>1</b>: Effective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        /// <summary>
        /// <para>The playlist name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program_name</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// <para>The recording configuration. If this parameter is empty, the recording feature is not enabled.</para>
        /// </summary>
        [NameInMap("RecordConfig")]
        [Validation(Required=false)]
        public DescribeCasterConfigResponseBodyRecordConfig RecordConfig { get; set; }
        public class DescribeCasterConfigResponseBodyRecordConfig : TeaModel {
            /// <summary>
            /// <para>The on-demand recording mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Disabled.</para>
            /// </description></item>
            /// <item><description><para>1: HTTP callback-based.</para>
            /// </description></item>
            /// <item><description><para>2: On-demand recording by parsing stream ingest parameters.</para>
            /// </description></item>
            /// <item><description><para>7: Not recorded by default.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnDemand")]
            [Validation(Required=false)]
            public int? OnDemand { get; set; }

            /// <summary>
            /// <para>The storage location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveBucket****</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The OSS endpoint of the storage location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyundoc.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            [NameInMap("RecordFormat")]
            [Validation(Required=false)]
            public DescribeCasterConfigResponseBodyRecordConfigRecordFormat RecordFormat { get; set; }
            public class DescribeCasterConfigResponseBodyRecordConfigRecordFormat : TeaModel {
                [NameInMap("RecordFormat")]
                [Validation(Required=false)]
                public List<DescribeCasterConfigResponseBodyRecordConfigRecordFormatRecordFormat> RecordFormat { get; set; }
                public class DescribeCasterConfigResponseBodyRecordConfigRecordFormatRecordFormat : TeaModel {
                    [NameInMap("CycleDuration")]
                    [Validation(Required=false)]
                    public int? CycleDuration { get; set; }

                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("OssObjectPrefix")]
                    [Validation(Required=false)]
                    public string OssObjectPrefix { get; set; }

                    [NameInMap("SliceOssObjectPrefix")]
                    [Validation(Required=false)]
                    public string SliceOssObjectPrefix { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97df6b7f-3490-47d2-ac50-8833e1b64597</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The custom side output URL of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://sophon-developer.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
        /// </summary>
        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        /// <summary>
        /// <para>The list of custom side output URLs of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;rtmp://domain/app1/stream1&quot;,&quot;rtmp://domain/app2/stream2&quot;]</para>
        /// </summary>
        [NameInMap("SideOutputUrlList")]
        [Validation(Required=false)]
        public string SideOutputUrlList { get; set; }

        [NameInMap("SyncGroupsConfig")]
        [Validation(Required=false)]
        public DescribeCasterConfigResponseBodySyncGroupsConfig SyncGroupsConfig { get; set; }
        public class DescribeCasterConfigResponseBodySyncGroupsConfig : TeaModel {
            [NameInMap("SyncGroup")]
            [Validation(Required=false)]
            public List<DescribeCasterConfigResponseBodySyncGroupsConfigSyncGroup> SyncGroup { get; set; }
            public class DescribeCasterConfigResponseBodySyncGroupsConfigSyncGroup : TeaModel {
                [NameInMap("HostResourceId")]
                [Validation(Required=false)]
                public string HostResourceId { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                [NameInMap("ResourceIds")]
                [Validation(Required=false)]
                public DescribeCasterConfigResponseBodySyncGroupsConfigSyncGroupResourceIds ResourceIds { get; set; }
                public class DescribeCasterConfigResponseBodySyncGroupsConfigSyncGroupResourceIds : TeaModel {
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public List<string> ResourceId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The transcoding configuration.</para>
        /// </summary>
        [NameInMap("TranscodeConfig")]
        [Validation(Required=false)]
        public DescribeCasterConfigResponseBodyTranscodeConfig TranscodeConfig { get; set; }
        public class DescribeCasterConfigResponseBodyTranscodeConfig : TeaModel {
            /// <summary>
            /// <para>The production studio transcoding template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lp_ld</b>: low definition.</description></item>
            /// <item><description><b>lp_sd</b>: standard definition.</description></item>
            /// <item><description><b>lp_hd</b>: high definition.</description></item>
            /// <item><description><b>lp_ud</b>: ultra-high definition.</description></item>
            /// <item><description><b>lp_ld_v</b>: portrait low definition.</description></item>
            /// <item><description><b>lp_sd_v</b>: portrait standard definition.</description></item>
            /// <item><description><b>lp_hd_v</b>: portrait high definition.</description></item>
            /// <item><description><b>lp_ud_v</b>: portrait ultra-high definition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lp_hd</para>
            /// </summary>
            [NameInMap("CasterTemplate")]
            [Validation(Required=false)]
            public string CasterTemplate { get; set; }

            /// <summary>
            /// <para>The custom configuration.</para>
            /// </summary>
            [NameInMap("CustomParams")]
            [Validation(Required=false)]
            public DescribeCasterConfigResponseBodyTranscodeConfigCustomParams CustomParams { get; set; }
            public class DescribeCasterConfigResponseBodyTranscodeConfigCustomParams : TeaModel {
                /// <summary>
                /// <para>The video parameters.</para>
                /// </summary>
                [NameInMap("video")]
                [Validation(Required=false)]
                public DescribeCasterConfigResponseBodyTranscodeConfigCustomParamsVideo Video { get; set; }
                public class DescribeCasterConfigResponseBodyTranscodeConfigCustomParamsVideo : TeaModel {
                    /// <summary>
                    /// <para>The video bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("bitrate")]
                    [Validation(Required=false)]
                    public int? Bitrate { get; set; }

                    /// <summary>
                    /// <para>The video frame rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("fps")]
                    [Validation(Required=false)]
                    public int? Fps { get; set; }

                    /// <summary>
                    /// <para>The video height. Unit: pixels (px).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <para>The video width. Unit: pixels (px).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1080</para>
                    /// </summary>
                    [NameInMap("width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }

            [NameInMap("LiveTemplateIds")]
            [Validation(Required=false)]
            public DescribeCasterConfigResponseBodyTranscodeConfigLiveTemplateIds LiveTemplateIds { get; set; }
            public class DescribeCasterConfigResponseBodyTranscodeConfigLiveTemplateIds : TeaModel {
                [NameInMap("LocationId")]
                [Validation(Required=false)]
                public List<string> LocationId { get; set; }

            }

        }

        /// <summary>
        /// <para>The media library asset ID of the standby image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a089175eb5f4427684fc0715159a****</para>
        /// </summary>
        [NameInMap("UrgentImageId")]
        [Validation(Required=false)]
        public string UrgentImageId { get; set; }

        /// <summary>
        /// <para>The URL of the standby image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/AppName/image.jpg">http://learn.aliyundoc.com/AppName/image.jpg</a></para>
        /// </summary>
        [NameInMap("UrgentImageUrl")]
        [Validation(Required=false)]
        public string UrgentImageUrl { get; set; }

        /// <summary>
        /// <para>The URL of the standby live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("UrgentLiveStreamUrl")]
        [Validation(Required=false)]
        public string UrgentLiveStreamUrl { get; set; }

        /// <summary>
        /// <para>The media library asset ID of the standby video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98646538-bcf9-4aef-bd4a-e6bb76588****</para>
        /// </summary>
        [NameInMap("UrgentMaterialId")]
        [Validation(Required=false)]
        public string UrgentMaterialId { get; set; }

    }

}
