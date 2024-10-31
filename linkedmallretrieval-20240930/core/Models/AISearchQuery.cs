// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkedmallRetrieval20240930.Models
{
    public class AISearchQuery : TeaModel {
        [NameInMap("card")]
        [Validation(Required=false)]
        public string Card { get; set; }

        [NameInMap("cardQuery")]
        [Validation(Required=false)]
        public string CardQuery { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("searchEngine")]
        [Validation(Required=false)]
        public string SearchEngine { get; set; }

        [NameInMap("searchPlan")]
        [Validation(Required=false)]
        public string SearchPlan { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
