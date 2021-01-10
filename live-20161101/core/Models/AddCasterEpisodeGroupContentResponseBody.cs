// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupContentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public AddCasterEpisodeGroupContentResponseBodyItemIds ItemIds { get; set; }
        public class AddCasterEpisodeGroupContentResponseBodyItemIds : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public List<string> ItemId { get; set; }
        };

    }

}
