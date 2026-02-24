// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourcesByAdvancedSearchResponseBody : TeaModel {
        [NameInMap("QueryResults")]
        [Validation(Required=false)]
        public ListResourcesByAdvancedSearchResponseBodyQueryResults QueryResults { get; set; }
        public class ListResourcesByAdvancedSearchResponseBodyQueryResults : TeaModel {
            [NameInMap("QueryResultList")]
            [Validation(Required=false)]
            public ListResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList QueryResultList { get; set; }
            public class ListResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList : TeaModel {
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
