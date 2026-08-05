// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterEpisodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, use the CasterId value that is returned in the response.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the LIVE console, find the ID on the Cloud Production Studio page. To go to the page, choose <b>LIVE Console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of a production studio in the list on the Cloud Production Studio page is the production studio ID.</para>
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
        /// <para>The IDs of the components. The components are arranged from bottom to top and are switched in sync with the video source.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required and takes effect only if EpisodeType is set to <b>Component</b>.</para>
        /// </description></item>
        /// <item><description><para>If EpisodeType is set to <b>Resource</b>, this parameter specifies the components that are attached to the video source and switched in sync.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>N specifies the Nth component ID. For example, ComponentId.1 specifies the first component ID and ComponentId.2 specifies the second component ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;16A96B9A-F203-4EC5-8E43-CB92E68F****&quot;]</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public List<string> ComponentId { get; set; }

        /// <summary>
        /// <para>The end time. The time must be in UTC. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T10:20:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the episode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf938623****</para>
        /// </summary>
        [NameInMap("EpisodeId")]
        [Validation(Required=false)]
        public string EpisodeId { get; set; }

        /// <summary>
        /// <para>The name of the episode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>episode_name_1</para>
        /// </summary>
        [NameInMap("EpisodeName")]
        [Validation(Required=false)]
        public string EpisodeName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the video source.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required and takes effect only if EpisodeType is set to <b>Resource</b>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not available if EpisodeType is set to <b>Component</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E683****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The start time. The time must be in UTC. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The switch policy. This parameter takes effect only if EpisodeType is set to <b>Resource</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>TimeFirst</b>: time-priority. This is the only policy available for live stream video sources.</para>
        /// </description></item>
        /// <item><description><para><b>ContentFirst</b>: content-priority.</para>
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

}
