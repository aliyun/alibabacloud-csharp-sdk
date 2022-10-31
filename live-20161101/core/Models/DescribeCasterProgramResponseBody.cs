// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeCasterProgramResponseBody : TeaModel {
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

        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
