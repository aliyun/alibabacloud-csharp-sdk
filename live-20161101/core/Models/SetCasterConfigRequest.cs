// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetCasterConfigRequest : TeaModel {
        /// <summary>
        /// <para>The automatic standby switchover configuration.
        /// <c>eofThres</c>: the duration of stream interruption after which the system automatically switches to the standby video, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;eofThres&quot;:3}</para>
        /// </summary>
        [NameInMap("AutoSwitchUrgentConfig")]
        [Validation(Required=false)]
        public string AutoSwitchUrgentConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic switchover to the standby video when the stream is interrupted.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoSwitchUrgentOn")]
        [Validation(Required=false)]
        public bool? AutoSwitchUrgentOn { get; set; }

        /// <summary>
        /// <para>The callback URL. To receive callback notifications, enter a valid receiving address that accepts the HTTP protocol. If this parameter is set to empty, callback notifications for the production studio are canceled by default.</para>
        /// <remarks>
        /// <para>For more information about production studio callbacks, see <a href="https://help.aliyun.com/document_detail/213633.html">Cloud production studio callback information</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId value returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, go to <b>ApsaraVideo Live console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the production studio list on the Cloud Production Studio page of the ApsaraVideo Live console is the production studio ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The name of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveCaster****</para>
        /// </summary>
        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Channel. If Channel was previously enabled (ChannelEnable=1), you must explicitly pass ChannelEnable=1 in each call to maintain the channel status. Otherwise, the error InvalidCaster.ChannelDisableUnsupported is returned.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): disabled.</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Channel is disabled by default and cannot be disabled after it is enabled. When Channel is disabled, resources are directly referenced by layouts. To enable Channel for the first time, the production studio must be stopped. Existing layouts are discarded. Resources must first be assigned to a Channel, and new layouts directly reference the Channel. Through Channel, you can adjust the playback progress and status of video sources. In this mode, if the video source, PVW, and PGM areas reference the same resource, the corresponding views remain synchronized.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelEnable")]
        [Validation(Required=false)]
        public int? ChannelEnable { get; set; }

        /// <summary>
        /// <para>The stream delay, in seconds.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): disables stream delay.</description></item>
        /// <item><description>Greater than <b>0</b>: enables stream delay.</description></item>
        /// <item><description><b>Empty</b>: clears the stream delay configuration by default.<remarks>
        /// <para>The maximum value is 300 seconds.</para>
        /// </remarks>
        /// </description></item>
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
        /// <para>Complete the domain name configuration before starting the production studio. If this parameter is empty, the domain name configuration of the production studio is cleared by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the program list takes effect. </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: does not take effect.</description></item>
        /// <item><description><b>1</b>: takes effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        /// <summary>
        /// <para>The name of the program list. This parameter can be configured when the program list feature is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program_name</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// <para>The recording configuration in JSON format. The configuration elements are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>endpoint</b>: the API endpoint of the Alibaba Cloud service.</description></item>
        /// <item><description><b>ossBucket</b>: the name of the OSS bucket.</description></item>
        /// <item><description><b>videoFormat</b>: the video file formats supported for export. Example: <c>[{\\&quot;OssObjectPrefix\\&quot;:\\&quot;record/{AppName}/{StreamName}/{StartTime}_{EndTime}\\&quot;,\\&quot;Format\\&quot;:\\&quot;m3u8\\&quot;,\\&quot;CycleDuration\\&quot;:21600,\\&quot;SliceOssObjectPrefix\\&quot;:\\&quot;record/{AppName}/{StreamName}/{UnixTimestamp}\\&quot;},{\\&quot;OssObjectPrefix\\&quot;:\\&quot;record/{AppName}/{StreamName}/{StartTime}_{EndTime}\\&quot;,\\&quot;Format\\&quot;:\\&quot;flv\\&quot;,\\&quot;CycleDuration\\&quot;:21600}]</c>.</description></item>
        /// <item><description><b>interval</b>: the time interval, in milliseconds (ms).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to empty, the recording feature is not enabled. If this parameter is set to empty, the recording configuration is cleared by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;endpoint&quot;: &quot;<a href="http://oss-cn-********.aliyuncs.com/api">http://oss-cn-********.aliyuncs.com/api</a>&quot;,  &quot;ossBucket****&quot;: &quot;liveBucket****&quot;, &quot;VideoFormat&quot;:[{\&quot;OssObjectPrefix\&quot;:\&quot;record/{AppName}/{StreamName}/{StartTime}<em>{EndTime}\&quot;,\&quot;Format\&quot;:\&quot;m3u8\&quot;,\&quot;CycleDuration\&quot;:21600,\&quot;SliceOssObjectPrefix\&quot;:\&quot;record/{AppName}/{StreamName}/{UnixTimestamp}\&quot;},{\&quot;OssObjectPrefix\&quot;:\&quot;record/{AppName}/{StreamName}/{StartTime}</em>{EndTime}\&quot;,\&quot;Format\&quot;:\&quot;flv\&quot;,\&quot;CycleDuration\&quot;:21600}] &quot;interval&quot;: 5 }</para>
        /// </summary>
        [NameInMap("RecordConfig")]
        [Validation(Required=false)]
        public string RecordConfig { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ingest URL that corresponds to the custom bypass output address of the production studio. 
        /// If this parameter is empty, the ingest URL that corresponds to the output address automatically generated by Alibaba Cloud is used by default.</para>
        /// <remarks>
        /// <para>Currently, SideOutputUrl supports only the RTMP protocol for stream ingest.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        /// <summary>
        /// <para>The list of multi-destination relay streaming addresses. The addresses can be CDN ingest URLs from Alibaba Cloud or third-party providers. A maximum of 20 RTMP relay addresses can be added to a production studio.</para>
        /// <remarks>
        /// <para>Specify multiple addresses in the array format: [&quot;rtmp://domain/app1/stream1&quot;,&quot;rtmp://domain/app2/stream2&quot;].</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://domain/app/stream?***</para>
        /// </summary>
        [NameInMap("SideOutputUrlList")]
        [Validation(Required=false)]
        public string SideOutputUrlList { get; set; }

        /// <summary>
        /// <para>The multi-view synchronization configuration that synchronizes multiple video sources.
        /// Multi-view synchronization has two modes:</para>
        /// <list type="bullet">
        /// <item><description><para>mode: 0 (streamer mode. Multiple video sources are synchronized based on the specified mode.)</para>
        /// </description></item>
        /// <item><description><para>mode: 1 (conference mode. There is no concept of a streamer video. All video sources are synchronized with each other.)</para>
        /// </description></item>
        /// </list>
        /// <para>Streamer mode: hostResourceId: the streamer video source in streamer mode.</para>
        /// <para>Conference mode: the hostResourceId field is not required. Only the resource IDs in resourceIds need to be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;[{\&quot;mode\&quot;:0,\&quot;resourceIds\&quot;:[\&quot;5a6c1c33-8424-46f6-813c-c152220a****\&quot;,\&quot;4e6521dc-a40a-4077-b6bf-1fb12a76****\&quot;],\&quot;hostResourceId\&quot;:\&quot;3aa2b39a-fd0e-4b8c-be73-b7af31c4****\&quot;}]&quot;</para>
        /// </summary>
        [NameInMap("SyncGroupsConfig")]
        [Validation(Required=false)]
        public string SyncGroupsConfig { get; set; }

        /// <summary>
        /// <para>The transcoding configuration. </para>
        /// <para>A JSON-formatted string. Use upper camel case for internal fields of the struct. If this parameter is set to empty, the transcoding configuration is cleared by default. If the transcoding template is empty, an error is returned when the production studio starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;casterTemplate&quot;: &quot;lp_ld&quot;}</para>
        /// </summary>
        [NameInMap("TranscodeConfig")]
        [Validation(Required=false)]
        public string TranscodeConfig { get; set; }

        /// <summary>
        /// <para>The media asset ID of the standby image in the media library.</para>
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
        /// <para>The media asset ID of the standby video in the media library. If this parameter is set to empty, the standby configuration is cleared by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671</para>
        /// </summary>
        [NameInMap("UrgentMaterialId")]
        [Validation(Required=false)]
        public string UrgentMaterialId { get; set; }

    }

}
