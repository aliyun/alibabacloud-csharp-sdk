// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListVectorQueryResultRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("vectorQueryType")]
        [Validation(Required=false)]
        public string VectorQueryType { get; set; }

    }

}
