// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourcesByAdvancedSearchResponseBody : TeaModel {
        [NameInMap("QueryResults")]
        [Validation(Required=false)]
        public ListAggregateResourcesByAdvancedSearchResponseBodyQueryResults QueryResults { get; set; }
        public class ListAggregateResourcesByAdvancedSearchResponseBodyQueryResults : TeaModel {
            [NameInMap("QueryResultList")]
            [Validation(Required=false)]
            public ListAggregateResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList QueryResultList { get; set; }
            public class ListAggregateResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList : TeaModel {
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<object> Values { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
