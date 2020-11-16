// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("Episode")]
        [Validation(Required=true)]
        public List<AddCasterProgramRequestEpisode> Episode { get; set; }
        public class AddCasterProgramRequestEpisode : TeaModel {
            [NameInMap("EpisodeType")]
            [Validation(Required=false)]
            public string EpisodeType { get; set; }

            [NameInMap("EpisodeName")]
            [Validation(Required=false)]
            public string EpisodeName { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public List<string> ComponentId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("SwitchType")]
            [Validation(Required=false)]
            public string SwitchType { get; set; }

        }

    }

}
