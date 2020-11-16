// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ProgramId")]
        [Validation(Required=true)]
        public string ProgramId { get; set; }

        [NameInMap("ItemIds")]
        [Validation(Required=true)]
        public AddCasterEpisodeGroupResponseItemIds ItemIds { get; set; }
        public class AddCasterEpisodeGroupResponseItemIds : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=true)]
            public List<string> ItemId { get; set; }
        };

    }

}
