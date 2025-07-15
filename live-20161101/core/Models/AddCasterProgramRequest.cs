// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramRequest : TeaModel {
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
        /// <para>The information about episodes in the episode list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Episode")]
        [Validation(Required=false)]
        public List<AddCasterProgramRequestEpisode> Episode { get; set; }
        public class AddCasterProgramRequestEpisode : TeaModel {
            /// <summary>
            /// <para>The components. Components in the production studio are listed from the bottom to the top in an array.</para>
            /// <remarks>
            /// <para> This parameter is required and takes effect when the Episode.N.EpisodeType parameter is set to Component.</para>
            /// </remarks>
            /// <para>This parameter is optional when the Episode.N.EpisodeType parameter is set to <b>Resource</b>. In this case, if this parameter is specified, the components are bound to and switched together with video resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[ &quot;a2b8e671-2fe5-4642-a2ec-bf931826****&quot;,  &quot;a2b8e671-2fe5-4642-a2ec-28374657****&quot;]</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public List<string> ComponentId { get; set; }

            /// <summary>
            /// <para>The end time of the episode. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T10:02:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the episode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>program_name_1</para>
            /// </summary>
            [NameInMap("EpisodeName")]
            [Validation(Required=false)]
            public string EpisodeName { get; set; }

            /// <summary>
            /// <para>The type of the episode.</para>
            /// <list type="bullet">
            /// <item><description><b>Resource</b>: a video resource If you set this parameter to Resource, you must specify the Episode.N.ResourceId and Episode.N.SwitchType parameters.</description></item>
            /// <item><description><b>Component</b>: a component If you set this parameter to Component, you must specify the Episode.N.ComponentId.N parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Resource</para>
            /// </summary>
            [NameInMap("EpisodeType")]
            [Validation(Required=false)]
            public string EpisodeType { get; set; }

            /// <summary>
            /// <para>The ID of the video resource.</para>
            /// <remarks>
            /// <para> This parameter takes effect and is required when the Episode.N.EpisodeType parameter is set to Resource.</para>
            /// </remarks>
            /// <para>\
            /// This parameter is invalid if you set the Episode.N.EpisodeType parameter to <b>Component</b>.</para>
            /// <para>If the video resource was added by calling the <a href="https://help.aliyun.com/document_detail/60250.html">AddCasterVideoResource</a> operation, check the value of the response parameter ResourceId to obtain the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The start time of the episode. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-06-29T09:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The policy for switching episodes. Valid values:</para>
            /// <remarks>
            /// <para> This parameter takes effect only when the Episode.N.EpisodeType parameter is set to Resource.</para>
            /// </remarks>
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
