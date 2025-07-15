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
        /// <para>The components. Components in the production studio are listed from the bottom to the top in an array. When the production studio switches to another video resource, the components are also switched.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect and is required only when the EpisodeType parameter is set to <b>Component</b>.</description></item>
        /// <item><description>This parameter is optional when the EpisodeType parameter is set to <b>Resource</b>. In this case, if this parameter is specified, the components are bound to and switched together with video resources.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The variable N specifies the sequence number of the component. For example, ComponentId.1 specifies the ID of the first component and ComponentId.2 specifies the ID of the second component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;16A96B9A-F203-4EC5-8E43-CB92E68F****&quot;]</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public List<string> ComponentId { get; set; }

        /// <summary>
        /// <para>The time when the episode ends. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T10:20:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the episode. It is included in the response when you call the <a href="~~94745#doc-api-live-AddCasterEpisode~~" title="Adds an episode to a production studio.">AddCasterEpisode</a> operation.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the video resource. It is included in the response when you call the <a href="~~60250#doc-api-live-AddCasterVideoResource~~" title="Adds a video resource to a production studio.">AddCasterVideoResource</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect and is required only when the EpisodeType is set to <b>Resource</b>.</description></item>
        /// <item><description>If the EpisodeType parameter is set to <b>Component</b>, this parameter is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E683****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The time when the episode starts. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T09:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The policy for switching episodes. This parameter takes effect only when the EpisodeType parameter is set to <b>Resource</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TimeFirst</b>: The episode starts when the preceding episode ends and ends when the next episode starts. If no next episode exists, the episode keeps repeating until a new episode is added or the production studio stops. This parameter must be set to TimeFirst when the video resource is a live stream.</description></item>
        /// <item><description><b>ContentFirst</b>: The episode starts and ends as scheduled.</description></item>
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
