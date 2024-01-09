// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20201210.Models
{
    public class SuggestCategoryRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        [NameInMap("UseHotSuggestCatchAll")]
        [Validation(Required=false)]
        public bool? UseHotSuggestCatchAll { get; set; }

    }

}
