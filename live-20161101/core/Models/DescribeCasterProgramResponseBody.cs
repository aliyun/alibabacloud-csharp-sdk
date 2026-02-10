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

        [NameInMap("Episodes")]
        [Validation(Required=false)]
        public DescribeCasterProgramResponseBodyEpisodes Episodes { get; set; }
        public class DescribeCasterProgramResponseBodyEpisodes : TeaModel {
            [NameInMap("Episode")]
            [Validation(Required=false)]
            public List<DescribeCasterProgramResponseBodyEpisodesEpisode> Episode { get; set; }
            public class DescribeCasterProgramResponseBodyEpisodesEpisode : TeaModel {
                [NameInMap("ComponentIds")]
                [Validation(Required=false)]
                public DescribeCasterProgramResponseBodyEpisodesEpisodeComponentIds ComponentIds { get; set; }
                public class DescribeCasterProgramResponseBodyEpisodesEpisodeComponentIds : TeaModel {
                    [NameInMap("ComponentId")]
                    [Validation(Required=false)]
                    public List<string> ComponentId { get; set; }

                }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EpisodeId")]
                [Validation(Required=false)]
                public string EpisodeId { get; set; }

                [NameInMap("EpisodeName")]
                [Validation(Required=false)]
                public string EpisodeName { get; set; }

                [NameInMap("EpisodeType")]
                [Validation(Required=false)]
                public string EpisodeType { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
