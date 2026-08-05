// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterProgramRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you create a production studio by calling the <a href="">CreateCaster</a> operation, use the value of the CasterId parameter that is returned in the response.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the ApsaraVideo Live console, go to the <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> page to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the list on the Cloud Production Studio page is the production studio ID.</para>
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
        /// <para>The program information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Episode")]
        [Validation(Required=false)]
        public List<ModifyCasterProgramRequestEpisode> Episode { get; set; }
        public class ModifyCasterProgramRequestEpisode : TeaModel {
            /// <summary>
            /// <para>The list of component IDs. The components are layered from bottom to top in the order they are listed. The components are switched in sync with the video source.</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter is required and takes effect only when the node type is <b>Component</b>.</para>
            /// </description></item>
            /// <item><description><para>If the node type is <b>Resource</b>, the components are attached to the video source and switched in sync.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;a2b8e671-2fe5-4642-a2ec-bf93888****&quot; ]</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public List<string> ComponentId { get; set; }

            /// <summary>
            /// <para>The end time. The time is in UTC. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T10:04:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The program ID. If you add a program for the production studio by calling the <a href="">AddCasterEpisode</a> operation, use the value of the EpisodeId parameter that is returned in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf938887****</para>
            /// </summary>
            [NameInMap("EpisodeId")]
            [Validation(Required=false)]
            public string EpisodeId { get; set; }

            /// <summary>
            /// <para>The program name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>program_name_2</para>
            /// </summary>
            [NameInMap("EpisodeName")]
            [Validation(Required=false)]
            public string EpisodeName { get; set; }

            /// <summary>
            /// <para>The program type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Resource</b>: video source.</para>
            /// </description></item>
            /// <item><description><para><b>Component</b>: component.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Resource</para>
            /// </summary>
            [NameInMap("EpisodeType")]
            [Validation(Required=false)]
            public string EpisodeType { get; set; }

            /// <summary>
            /// <para>The ID of the video source. If you add a video source for the production studio by calling the <a href="">AddCasterVideoResource</a> operation, use the value of the ResourceId parameter that is returned in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf938887****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The start time. The time is in UTC. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T09:02:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The switch policy. This parameter is valid only when the node type is <b>Resource</b>.</para>
            /// <list type="bullet">
            /// <item><description><para><b>TimeFirst</b>: time-first. This is the only valid policy for live stream video sources.</para>
            /// </description></item>
            /// <item><description><para><b>ContentFirst</b>: content-first.</para>
            /// </description></item>
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
