// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("EpisodeIds")]
        [Validation(Required=true)]
        public AddCasterProgramResponseEpisodeIds EpisodeIds { get; set; }
        public class AddCasterProgramResponseEpisodeIds : TeaModel {
            [NameInMap("EpisodeId")]
            [Validation(Required=true)]
            public List<AddCasterProgramResponseEpisodeIdsEpisodeId> EpisodeId { get; set; }
            public class AddCasterProgramResponseEpisodeIdsEpisodeId : TeaModel {
                public string EpisodeId { get; set; }
            }
        };

    }

}
