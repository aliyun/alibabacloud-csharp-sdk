// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterProgramResponseBody : TeaModel {
        [NameInMap("EpisodeIds")]
        [Validation(Required=false)]
        public AddCasterProgramResponseBodyEpisodeIds EpisodeIds { get; set; }
        public class AddCasterProgramResponseBodyEpisodeIds : TeaModel {
            [NameInMap("EpisodeId")]
            [Validation(Required=false)]
            public List<AddCasterProgramResponseBodyEpisodeIdsEpisodeId> EpisodeId { get; set; }
            public class AddCasterProgramResponseBodyEpisodeIdsEpisodeId : TeaModel {
                public string EpisodeId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
