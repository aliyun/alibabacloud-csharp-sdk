// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterProgramResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("ProgramName")]
        [Validation(Required=true)]
        public string ProgramName { get; set; }

        [NameInMap("ProgramEffect")]
        [Validation(Required=true)]
        public int? ProgramEffect { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Episodes")]
        [Validation(Required=true)]
        public DescribeCasterProgramResponseEpisodes Episodes { get; set; }
        public class DescribeCasterProgramResponseEpisodes : TeaModel {
            [NameInMap("Episode")]
            [Validation(Required=true)]
            public List<DescribeCasterProgramResponseEpisodesEpisode> Episode { get; set; }
            public class DescribeCasterProgramResponseEpisodesEpisode : TeaModel {
                public string EpisodeId { get; set; }
                public string EpisodeType { get; set; }
                public string EpisodeName { get; set; }
                public string ResourceId { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public string SwitchType { get; set; }
                public int? Status { get; set; }
                public DescribeCasterProgramResponseEpisodesEpisodeComponentIds ComponentIds { get; set; }
                public class DescribeCasterProgramResponseEpisodesEpisodeComponentIds : TeaModel {
                    /// <summary>
                    /// ComponentId
                    /// </summary>
                    [NameInMap("ComponentId")]
                    [Validation(Required=true)]
                    public List<string> ComponentId { get; set; }

                }
            }
        };

    }

}
