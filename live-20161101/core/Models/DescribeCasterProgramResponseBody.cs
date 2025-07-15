// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterProgramResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The list of the episodes.</para>
        /// </summary>
        [NameInMap("Episodes")]
        [Validation(Required=false)]
        public DescribeCasterProgramResponseBodyEpisodes Episodes { get; set; }
        public class DescribeCasterProgramResponseBodyEpisodes : TeaModel {
            [NameInMap("Episode")]
            [Validation(Required=false)]
            public List<DescribeCasterProgramResponseBodyEpisodesEpisode> Episode { get; set; }
            public class DescribeCasterProgramResponseBodyEpisodesEpisode : TeaModel {
                /// <summary>
                /// <para>The components.</para>
                /// </summary>
                [NameInMap("ComponentIds")]
                [Validation(Required=false)]
                public DescribeCasterProgramResponseBodyEpisodesEpisodeComponentIds ComponentIds { get; set; }
                public class DescribeCasterProgramResponseBodyEpisodesEpisodeComponentIds : TeaModel {
                    [NameInMap("ComponentId")]
                    [Validation(Required=false)]
                    public List<string> ComponentId { get; set; }

                }

                /// <summary>
                /// <para>The end of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-06-29T10:02:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the episode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1872639A-F203-4EC5-8E43-CB92E68F****</para>
                /// </summary>
                [NameInMap("EpisodeId")]
                [Validation(Required=false)]
                public string EpisodeId { get; set; }

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
                /// <para>The ID of the video resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1872639A-F203-4EC5-8E43-CB92E837****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-06-29T09:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the episode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The policy for switching episodes. Valid values:</para>
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

        }

        /// <summary>
        /// <para>Indicates whether carousel playback is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Carousel playback is disabled.</description></item>
        /// <item><description><b>1</b>: Carousel playback is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        /// <summary>
        /// <para>The name of the episode list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>programs_name</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
