// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("Episode")]
        [Validation(Required=false)]
        public List<AddCasterProgramRequestEpisode> Episode { get; set; }
        public class AddCasterProgramRequestEpisode : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("EpisodeName")]
            [Validation(Required=false)]
            public string EpisodeName { get; set; }

            [NameInMap("EpisodeType")]
            [Validation(Required=false)]
            public string EpisodeType { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public List<string> ComponentId { get; set; }

            [NameInMap("SwitchType")]
            [Validation(Required=false)]
            public string SwitchType { get; set; }

        }

    }

}
