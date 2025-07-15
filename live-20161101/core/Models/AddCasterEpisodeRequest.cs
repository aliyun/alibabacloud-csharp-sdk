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
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
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
        /// <para>The components. Components in the production studio are listed from the bottom to the top in an array.</para>
        /// <para>If a component was added by calling the <a href="https://help.aliyun.com/document_detail/2848030.html">AddCasterComponent</a> operation, check the value of the response parameter ComponentId to obtain the component ID.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect and is required when the EpisodeType parameter is set to <b>Component</b>.</description></item>
        /// <item><description>This parameter is optional when the EpisodeType parameter is set to <b>Resource</b>. In this case, if this parameter is specified, the components are bound to and switched together with video resources.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The variable N specifies the sequence number of the component. For example, <b>ComponentId.1</b> specifies the ID of the first component and <b>ComponentId.2</b> specifies the ID of the second component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a2b8e671-2fe5-4642-a2ec-bf93880e****&quot;]</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public List<string> ComponentId { get; set; }

        /// <summary>
        /// <para>The time when the episode ends. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
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
        /// <para>The type of the episode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Resource</b>: a video resource.</description></item>
        /// <item><description><b>Component</b>: a component.</description></item>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the video resource.</para>
        /// <remarks>
        /// <para> This parameter takes effect and is required when the EpisodeType parameter is set to Resource.</para>
        /// </remarks>
        /// <para>\
        /// If the video resource was added by calling the <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a> operation, check the value of the response parameter ResourceId to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The time when the episode starts. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The policy for switching episodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TimeFirst</b>: The episode starts when the preceding episode ends and ends when the next episode starts. If no next episode exists, the episode keeps repeating until a new episode is added or the production studio stops.</description></item>
        /// <item><description><b>ContentFirst</b>: The episode starts and ends as scheduled.</description></item>
        /// </list>
        /// <para>This parameter takes effect only when the EpisodeType parameter is set to Resource.</para>
        /// <remarks>
        /// <para> This parameter must be set to TimeFirst when the video resource is a live stream.</para>
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
