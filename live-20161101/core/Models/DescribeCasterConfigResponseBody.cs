// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration for automatic switchover to the standby resource. The <c>eofThres</c> field specifies the duration after which the production studio automatically switches to the standby resource if a stream interruption occurs. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;eofThres&quot;:3}</para>
        /// </summary>
        [NameInMap("AutoSwitchUrgentConfig")]
        [Validation(Required=false)]
        public string AutoSwitchUrgentConfig { get; set; }

        /// <summary>
        /// <para>Indicates whether the production studio automatically switches to the standby resource in case of a stream interruption.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoSwitchUrgentOn")]
        [Validation(Required=false)]
        public string AutoSwitchUrgentOn { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://learn.aliyundoc.com/callBackLive">http://learn.aliyundoc.com/callBackLive</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The name of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coco-caster10</para>
        /// </summary>
        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        /// <summary>
        /// <para>Indicates whether channels are enabled for the production studio. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Channels are disabled.</description></item>
        /// <item><description><b>1</b>: Channels are enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelEnable")]
        [Validation(Required=false)]
        public int? ChannelEnable { get; set; }

        /// <summary>
        /// <para>Indicates whether stream delay is enabled. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Stream delay is disabled.</description></item>
        /// <item><description><b>A value greater than 0</b>: Stream delay is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Delay")]
        [Validation(Required=false)]
        public float? Delay { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Indicates whether the carousel playback feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The carousel playback feature is disabled.</description></item>
        /// <item><description><b>1</b>: The carousel playback feature is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        /// <summary>
        /// <para>The name of the playlist for carousel playback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program_name</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// <para>The recording configuration. If this parameter is empty, the recording feature is disabled.</para>
        /// </summary>
        [NameInMap("RecordConfig")]
        [Validation(Required=false)]
        public DescribeCasterConfigResponseBodyRecordConfig RecordConfig { get; set; }
        public class DescribeCasterConfigResponseBodyRecordConfig : TeaModel {
            /// <summary>
            /// <para>On-demand recording. Values:</para>
            /// <list type="bullet">
            /// <item><description>0: Off. </description></item>
            /// <item><description>1: Via HTTP callback. </description></item>
            /// <item><description>2: Parse streaming parameters for on-demand recording. </description></item>
            /// <item><description>7: Default to not record.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OnDemand")]
            [Validation(Required=false)]
            public int? OnDemand { get; set; }

            /// <summary>
            /// <para>The OSS bucket for storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveBucket****</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyundoc.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <para>The recording configuration.</para>
            /// </summary>
            [NameInMap("RecordFormat")]
            [Validation(Required=false)]
            public DescribeCasterConfigResponseBodyRecordConfigRecordFormat RecordFormat { get; set; }
            public class DescribeCasterConfigResponseBodyRecordConfigRecordFormat : TeaModel {
                [NameInMap("RecordFormat")]
                [Validation(Required=false)]
                public List<DescribeCasterConfigResponseBodyRecordConfigRecordFormatRecordFormat> RecordFormat { get; set; }
                public class DescribeCasterConfigResponseBodyRecordConfigRecordFormatRecordFormat : TeaModel {
                    /// <summary>
                    /// <para>The length of the recording.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("CycleDuration")]
                    [Validation(Required=false)]
                    public int? CycleDuration { get; set; }

                    /// <summary>
                    /// <para>The format of the recording.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>M3U8</para>
                    /// </summary>
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The name of the recording.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>record/{liveApp****}/{liveStream****}</para>
                    /// </summary>
                    [NameInMap("OssObjectPrefix")]
                    [Validation(Required=false)]
                    public string OssObjectPrefix { get; set; }

                    /// <summary>
                    /// <para>The name of the segment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>record/{liveApp****}/{liveStream****}/{UnixTimestamp****}</para>
                    /// </summary>
                    [NameInMap("SliceOssObjectPrefix")]
                    [Validation(Required=false)]
                    public string SliceOssObjectPrefix { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97df6b7f-3490-47d2-ac50-8833e1b64597</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The custom stream redirect URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://sophon-developer.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
        /// </summary>
        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        /// <summary>
        /// <para>The list of custom stream redirect URLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://sophon-developer.aliyundoc.com/caster/4a82a3d1b7f0462ea37348366201****?auth_key=1608953344-0-0-ac8c628078541d7055a170ec59a5****</para>
        /// </summary>
        [NameInMap("SideOutputUrlList")]
        [Validation(Required=false)]
        public string SideOutputUrlList { get; set; }

        /// <summary>
        /// <para>The storage configuration.</para>
        /// </summary>
        [NameInMap("SyncGroupsConfig")]
        [Validation(Required=false)]
        public DescribeCasterConfigResponseBodySyncGroupsConfig SyncGroupsConfig { get; set; }
        public class DescribeCasterConfigResponseBodySyncGroupsConfig : TeaModel {
            [NameInMap("SyncGroup")]
            [Validation(Required=false)]
            public List<DescribeCasterConfigResponseBodySyncGroupsConfigSyncGroup> SyncGroup { get; set; }
            public class DescribeCasterConfigResponseBodySyncGroupsConfigSyncGroup : TeaModel {
                /// <summary>
                /// <para>The ID of the resource in the production studio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28768383240243****</para>
                /// </summary>
                [NameInMap("HostResourceId")]
                [Validation(Required=false)]
                public string HostResourceId { get; set; }

                /// <summary>
                /// <para>The cache mode of the Static Page Caching policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: standard mode</description></item>
                /// <item><description>1: force mode</description></item>
                /// <item><description>2: no cache</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// <para>The IDs of the resources for which you want to modify the resource group. The number of resource IDs is 1 to 50.</para>
                /// </summary>
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
            /// <para>The transcoding template of the production studio. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lp_ld</b>: low definition</description></item>
            /// <item><description><b>lp_sd</b>: standard definition</description></item>
            /// <item><description><b>lp_hd</b>: high definition</description></item>
            /// <item><description><b>lp_ud</b>: ultra high definition</description></item>
            /// <item><description><b>lp_ld_v</b>: low definition (portrait mode)</description></item>
            /// <item><description><b>lp_sd_v</b>: standard definition (portrait mode)</description></item>
            /// <item><description><b>lp_hd_v</b>: high definition (portrait mode)</description></item>
            /// <item><description><b>lp_ud_v</b>: ultra high definition (portrait mode)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lp_hd</para>
            /// </summary>
            [NameInMap("CasterTemplate")]
            [Validation(Required=false)]
            public string CasterTemplate { get; set; }

            /// <summary>
            /// <para>The custom settings.</para>
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
                    /// <para>The video height. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <para>The video width. Unit: pixels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1080</para>
                    /// </summary>
                    [NameInMap("width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }

            /// <summary>
            /// <para>The transcoding setting for live streams.</para>
            /// </summary>
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
        /// <para>Prepared broadcast image media asset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a089175eb5f4427684fc0715159a****</para>
        /// </summary>
        [NameInMap("UrgentImageId")]
        [Validation(Required=false)]
        public string UrgentImageId { get; set; }

        /// <summary>
        /// <para>URL of the standby image material.</para>
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
        /// <para>The ID of the material that is used as the standby video from the media library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98646538-bcf9-4aef-bd4a-e6bb76588****</para>
        /// </summary>
        [NameInMap("UrgentMaterialId")]
        [Validation(Required=false)]
        public string UrgentMaterialId { get; set; }

    }

}
