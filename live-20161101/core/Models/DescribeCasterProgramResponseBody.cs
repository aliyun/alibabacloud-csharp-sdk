// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterProgramResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Episodes")]
        [Validation(Required=false)]
        public DescribeCasterProgramResponseBodyEpisodes Episodes { get; set; }
        public class DescribeCasterProgramResponseBodyEpisodes : TeaModel {
            [NameInMap("Episode")]
            [Validation(Required=false)]
            public List<DescribeCasterProgramResponseBodyEpisodesEpisode> Episode { get; set; }
            public class DescribeCasterProgramResponseBodyEpisodesEpisode : TeaModel {
                public int? Status { get; set; }
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string EpisodeName { get; set; }
                public string EpisodeType { get; set; }
                public string EpisodeId { get; set; }
                public string ResourceId { get; set; }
                public string SwitchType { get; set; }
                public DescribeCasterProgramResponseBodyEpisodesEpisodeComponentIds ComponentIds { get; set; }
                public class DescribeCasterProgramResponseBodyEpisodesEpisodeComponentIds : TeaModel {
                    [NameInMap("ComponentId")]
                    [Validation(Required=false)]
                    public List<string> ComponentId { get; set; }

                }
            }
        };

        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

    }

}
