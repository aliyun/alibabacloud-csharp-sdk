// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetCasterConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for automatic switchover to the standby resource.</para>
        /// <para>The <c>eofThres</c> field specifies the duration after which the production studio automatically switches to the standby resource if a stream interruption occurs. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;eofThres&quot;:3}</para>
        /// </summary>
        [NameInMap("AutoSwitchUrgentConfig")]
        [Validation(Required=false)]
        public string AutoSwitchUrgentConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether the production studio automatically switches to the standby resource in case of a stream interruption.</para>
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
        public bool? AutoSwitchUrgentOn { get; set; }

        /// <summary>
        /// <para>The callback URL. Enter a valid HTTP address for receiving callback notifications. If you do not specify this parameter, the production studio does not send callback notifications.</para>
        /// <remarks>
        /// <para> For more information about production studio callbacks, see <a href="https://help.aliyun.com/document_detail/213633.html">Production studio callbacks</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
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
        /// <para>Specifies whether to enable channels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): disables channels.</description></item>
        /// <item><description><b>1</b>: enables channels.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You cannot disable channels after you enable them. If you set this parameter to 0, the production studio references video resources in a layout without using channels. If you enable channels for the first time, make sure that the production studio is in the idle state. After you enable channels, a new layout that references video resources by using channels is generated to replace the original one. Therefore, you must specify video resources for channels. You can use the channels to change the playback progress or status. If the video resource, preview, and program modules of the production studio use the same video source, the three modules display the same content.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelEnable")]
        [Validation(Required=false)]
        public int? ChannelEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable stream delay. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): disables stream delay.</para>
        /// </description></item>
        /// <item><description><para><b>A value greater than 0</b>: enables stream delay.</para>
        /// </description></item>
        /// <item><description><para><b>Empty</b>: clears the stream delay configuration.</para>
        /// <para>**</para>
        /// <para>**Note **The maximum value can be 300 seconds.</para>
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
        /// <para>The main streaming domain.</para>
        /// <para>Complete the configuration of the domain name before the production studio is started. If you do not specify this parameter, the domain configuration for the production studio is cleared.</para>
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
        /// <para>Specifies whether to enable the carousel playback feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables carousel playback.</description></item>
        /// <item><description><b>1</b>: enables carousel playback.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        /// <summary>
        /// <para>The name of the playlist for carousel playback. You can specify this parameter if you enable the carousel playback feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program_name</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// <para>The recording configuration. The value is a JSON string. You can configure the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>endpoint</b>: the API server address of an Alibaba Cloud service.</description></item>
        /// <item><description><b>ossBucket</b>: the name of the Object Storage Service (OSS) bucket.</description></item>
        /// <item><description><b>videoFormat</b>: the format in which the video file can be exported. Example: <c>[{\\&quot;OssObjectPrefix\\&quot;:\\&quot;record/{AppName}/{StreamName}/{StartTime}_{EndTime}\\&quot;,\\&quot;Format\\&quot;:\\&quot;m3u8\\&quot;,\\&quot;CycleDuration\\&quot;:21600,\\&quot;SliceOssObjectPrefix\\&quot;:\\&quot;record/{AppName}/{StreamName}/{UnixTimestamp}\\&quot;},{\\&quot;OssObjectPrefix\\&quot;:\\&quot;record/{AppName}/{StreamName}/{StartTime}_{EndTime}\\&quot;,\\&quot;Format\\&quot;:\\&quot;flv\\&quot;,\\&quot;CycleDuration\\&quot;:21600}]</c>.</description></item>
        /// <item><description><b>interval</b>: the interval between recordings. Unit: milliseconds.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the recording feature is disabled and the recording configuration for the production studio is cleared.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;endpoint&quot;: &quot;<a href="http://oss-cn-********.aliyuncs.com/api">http://oss-cn-********.aliyuncs.com/api</a>&quot;,  &quot;ossBucket****&quot;: &quot;liveBucket****&quot;, &quot;VideoFormat&quot;:[{\&quot;OssObjectPrefix\&quot;:\&quot;record/{AppName}/{StreamName}/{StartTime}<em>{EndTime}\&quot;,\&quot;Format\&quot;:\&quot;m3u8\&quot;,\&quot;CycleDuration\&quot;:21600,\&quot;SliceOssObjectPrefix\&quot;:\&quot;record/{AppName}/{StreamName}/{UnixTimestamp}\&quot;},{\&quot;OssObjectPrefix\&quot;:\&quot;record/{AppName}/{StreamName}/{StartTime}</em>{EndTime}\&quot;,\&quot;Format\&quot;:\&quot;flv\&quot;,\&quot;CycleDuration\&quot;:21600}] &quot;interval&quot;: 5 }</para>
        /// </summary>
        [NameInMap("RecordConfig")]
        [Validation(Required=false)]
        public string RecordConfig { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The custom stream redirect URL.</para>
        /// <para>If you do not specify this parameter, the production studio uses the redirect URL generated by the system.</para>
        /// <remarks>
        /// <para>Redirect URLs support only the Real-Time Messaging Protocol (RTMP) protocol.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        /// <summary>
        /// <para>The stream relay URLs. A relay URL can be an Alibaba Cloud URL or a URL from a third-party CDN provider. You can specify up to 20 relay URLs over the RTMP protocol.</para>
        /// <remarks>
        /// <para>Use the following format to specify multiple relay URLs: &quot;rtmp://domain/app1/stream1&quot;,&quot;rtmp://domain/app2/stream2&quot;.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://domain/app/stream?***</para>
        /// </summary>
        [NameInMap("SideOutputUrlList")]
        [Validation(Required=false)]
        public string SideOutputUrlList { get; set; }

        /// <summary>
        /// <para>The multi-view synchronization configuration. You can specify this parameter to synchronize multiple video sources.</para>
        /// <para>There are two modes of multi-view synchronization.</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 for the mode field specifies the streamer mode. In this mode, multiple video sources are synchronized based on the settings by the streamer.</description></item>
        /// <item><description>A value of 1 for the mode field specifies the conference mode. In this mode, all video sources are synchronized.</description></item>
        /// </list>
        /// <para>In the streamer mode, the hostResourceId field specifies the video source on the streamer side.</para>
        /// <para>In the conference mode, the hostResourceId field is not available. You need to provide only resource IDs that are required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;[{\&quot;mode\&quot;:0,\&quot;resourceIds\&quot;:[\&quot;5a6c1c33-8424-46f6-813c-c152220a****\&quot;,\&quot;4e6521dc-a40a-4077-b6bf-1fb12a76****\&quot;],\&quot;hostResourceId\&quot;:\&quot;3aa2b39a-fd0e-4b8c-be73-b7af31c4****\&quot;}]&quot;</para>
        /// </summary>
        [NameInMap("SyncGroupsConfig")]
        [Validation(Required=false)]
        public string SyncGroupsConfig { get; set; }

        /// <summary>
        /// <para>The transcoding configuration.</para>
        /// <para>The value is a JSON string. Use upper camel case for fields of the string. If you do not specify this parameter, the transcoding configuration is cleared. If no transcoding template is available, an error occurs when the production studio is started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;casterTemplate&quot;: &quot;lp_ld&quot;}</para>
        /// </summary>
        [NameInMap("TranscodeConfig")]
        [Validation(Required=false)]
        public string TranscodeConfig { get; set; }

        /// <summary>
        /// <para>The ID of the standby image from the media library.</para>
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
        /// <para>The ID of the standby video from the media library. If you do not specify this parameter, the standby video configuration for the production studio is cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671</para>
        /// </summary>
        [NameInMap("UrgentMaterialId")]
        [Validation(Required=false)]
        public string UrgentMaterialId { get; set; }

    }

}
