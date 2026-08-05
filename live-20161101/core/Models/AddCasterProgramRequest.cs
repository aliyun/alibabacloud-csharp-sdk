// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster operation</a>, check the CasterId value returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, navigate to <b>ApsaraVideo Live console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> to view the production studio name.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the production studio list on the Cloud Production Studio page is the production studio ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The program list information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Episode")]
        [Validation(Required=false)]
        public List<AddCasterProgramRequestEpisode> Episode { get; set; }
        public class AddCasterProgramRequestEpisode : TeaModel {
            /// <summary>
            /// <para>The component list. Elements are arranged from bottom to top in order.</para>
            /// <remarks>
            /// <para>Notice: This parameter is valid and required when Episode.N.EpisodeType is set to <b>Component</b>.</para>
            /// </remarks>
            /// <para> When the node type is <b>Resource</b>, this indicates that the component is bound to the video source and switches synchronously.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[ &quot;a2b8e671-2fe5-4642-a2ec-bf931826****&quot;,  &quot;a2b8e671-2fe5-4642-a2ec-28374657****&quot;]</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public List<string> ComponentId { get; set; }

            /// <summary>
            /// <para>The end time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC). This parameter is required. If not specified, MissingParameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T10:02:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The program name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>program_name_1</para>
            /// </summary>
            [NameInMap("EpisodeName")]
            [Validation(Required=false)]
            public string EpisodeName { get; set; }

            /// <summary>
            /// <para>The node type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>Resource</b>: video source. If you select Resource, you must also set the request parameters Episode.N.ResourceId and Episode.N.SwitchType.</description></item>
            /// <item><description><b>Component</b>: component. If you select Component, you must also set the request parameter Episode.N.ComponentId.N.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When Resource is selected and the referenced resource contains a VodUrl (video-on-demand file), EndTime - StartTime cannot exceed the actual playback duration (in seconds) of the VOD file. Otherwise, InvalidParameter.EndTime is returned.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Resource</para>
            /// </summary>
            [NameInMap("EpisodeType")]
            [Validation(Required=false)]
            public string EpisodeType { get; set; }

            /// <summary>
            /// <para>The video source ID.</para>
            /// <remarks>
            /// <para>Notice: This parameter is valid and required when Episode.N.EpisodeType is set to <b>Resource</b>.</para>
            /// </remarks>
            /// <para> This parameter is not applicable when Episode.N.EpisodeType is set to <b>Component</b>.</para>
            /// <para>If you added the video source by calling the <a href="https://help.aliyun.com/document_detail/60250.html">AddCasterVideoResource operation</a>, check the ResourceId value returned by the AddCasterVideoResource operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The start time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC). This parameter is required. If not specified, MissingParameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T09:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The switch policy. Valid values:</para>
            /// <remarks>
            /// <para>Notice: This parameter is valid only when Episode.N.EpisodeType is set to <b>Resource</b>.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><b>TimeFirst</b>: time first. Live video sources can only use the time first policy. </description></item>
            /// <item><description><b>ContentFirst</b>: content first.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TimeFirst</para>
            /// </summary>
            [NameInMap("SwitchType")]
            [Validation(Required=false)]
            public string SwitchType { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
