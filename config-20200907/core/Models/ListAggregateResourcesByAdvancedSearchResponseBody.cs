// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourcesByAdvancedSearchResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("QueryResults")]
        [Validation(Required=false)]
        public ListAggregateResourcesByAdvancedSearchResponseBodyQueryResults QueryResults { get; set; }
        public class ListAggregateResourcesByAdvancedSearchResponseBodyQueryResults : TeaModel {
            /// <summary>
            /// <para>The queried resources. A maximum of 1,000 data records can be returned. To view more data, use the download URL of the resource file.</para>
            /// </summary>
            [NameInMap("QueryResultList")]
            [Validation(Required=false)]
            public ListAggregateResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList QueryResultList { get; set; }
            public class ListAggregateResourcesByAdvancedSearchResponseBodyQueryResultsQueryResultList : TeaModel {
                /// <summary>
                /// <para>The field names.</para>
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                /// <summary>
                /// <para>The resource data.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<object> Values { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B0DBF868-460F-5E7C-8F76-1ACE2FCCE153</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
