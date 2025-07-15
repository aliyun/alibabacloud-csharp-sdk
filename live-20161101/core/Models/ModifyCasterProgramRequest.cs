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
        /// <para>The episodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Episode")]
        [Validation(Required=false)]
        public List<ModifyCasterProgramRequestEpisode> Episode { get; set; }
        public class ModifyCasterProgramRequestEpisode : TeaModel {
            /// <summary>
            /// <para>The components. Components in the production studio are listed from the bottom to the top in an array. When the production studio switches to another video resource, the components are also switched.</para>
            /// <list type="bullet">
            /// <item><description>This parameter is required and available only when EpisodeType is set to <b>Component</b>.</description></item>
            /// <item><description>This parameter is optional when EpisodeType is set to <b>Resource</b>. This indicates that the components are bound to and switched together with video resources.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;a2b8e671-2fe5-4642-a2ec-bf93888****&quot; ]</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public List<string> ComponentId { get; set; }

            /// <summary>
            /// <para>The end time of the episode. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T10:04:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the episode. If the episode was added by calling the <a href="https://help.aliyun.com/document_detail/2848068.html">AddCasterEpisode</a> operation, check the value of the response parameter EpisodeId to obtain the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf938887****</para>
            /// </summary>
            [NameInMap("EpisodeId")]
            [Validation(Required=false)]
            public string EpisodeId { get; set; }

            /// <summary>
            /// <para>The name of the episode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>program_name_2</para>
            /// </summary>
            [NameInMap("EpisodeName")]
            [Validation(Required=false)]
            public string EpisodeName { get; set; }

            /// <summary>
            /// <para>The type of the episode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Resource</b>: a video resource</description></item>
            /// <item><description><b>Component</b>: a component</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Resource</para>
            /// </summary>
            [NameInMap("EpisodeType")]
            [Validation(Required=false)]
            public string EpisodeType { get; set; }

            /// <summary>
            /// <para>The ID of the video resource. If the video resource was added by calling the <a href="https://help.aliyun.com/document_detail/2848020.html">AddCasterVideoResource</a> operation, check the value of the response parameter ResourceId to obtain the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf938887****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The start time of the episode. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T09:02:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The policy for switching episodes. This parameter takes effect only when EpisodeType is set to <b>Resource</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TimeFirst</b>: The episode starts when the previous episode ends and ends when the next episode starts. If no next episode exists, the episode keeps repeating until a new episode is added or the production studio stops. This value is required for live video resources.</description></item>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
