// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you create a production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the CasterId parameter that is returned.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the LIVE console, go to the <b>LIVE Console</b>&gt; <b>Production Studio</b> &gt; <b>Production Studio</b> page to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the production studio list serves as the production studio ID.</para>
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
        /// <para>A list of component IDs. The components are layered from bottom to top in the specified order.</para>
        /// <para>If you add a component by calling the <a href="https://help.aliyun.com/document_detail/2848030.html">AddCasterComponent</a> operation, check the value of the ComponentId parameter that is returned.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required and applies only when the resource type is <b>Component</b>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is optional when the resource type is <b>Resource</b>. If you specify this parameter, the component is attached to the video source and they are switched synchronously.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>N specifies the sequence number of a component ID. For example, <b>ComponentId.1</b> specifies the first component ID and <b>ComponentId.2</b> specifies the second component ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a2b8e671-2fe5-4642-a2ec-bf93880e****&quot;]</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public List<string> ComponentId { get; set; }

        /// <summary>
        /// <para>The end time. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the episode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>episode_1</para>
        /// </summary>
        [NameInMap("EpisodeName")]
        [Validation(Required=false)]
        public string EpisodeName { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Resource</b>: A video source. If you set this parameter to Resource, you must also specify the ResourceId and SwitchType parameters.</para>
        /// </description></item>
        /// <item><description><para><b>Component</b>: A component.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("EpisodeType")]
        [Validation(Required=false)]
        public string EpisodeType { get; set; }

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

        /// <summary>
        /// <para>The ID of the video source.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required and applies only when EpisodeType is set to Resource.</para>
        /// <para>If you add a video source by calling the <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a> operation, check the value of the ResourceId parameter that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The start time. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The switch policy. Valid values:</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter applies only when EpisodeType is set to Resource.</para>
        /// <list type="bullet">
        /// <item><description><para><b>TimeFirst</b>: Time first.</para>
        /// </description></item>
        /// <item><description><para><b>ContentFirst</b>: Content first.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about video sources, see <a href="https://help.aliyun.com/document_detail/66094.html">Add a video source</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TimeFirst</para>
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

    }

}
