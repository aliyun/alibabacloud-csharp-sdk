// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourcesByAdvancedSearchResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("QueryResults")]
        [Validation(Required=false)]
        public ListAggregateResourcesByAdvancedSearchResponseBodyQueryResults QueryResults { get; set; }
        public class ListAggregateResourcesByAdvancedSearchResponseBodyQueryResults : TeaModel {
            /// <summary>
            /// The queried resources. A maximum of 1,000 data records can be returned. To view more data, use the download URL of the resource file.
            /// </summary>
            [NameInMap("QueryResultList")]
            [Validation(Required=false)]
            public ListAggregateResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList QueryResultList { get; set; }
            public class ListAggregateResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList : TeaModel {
                /// <summary>
                /// The field names.
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                /// <summary>
                /// The resource data.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<object> Values { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
