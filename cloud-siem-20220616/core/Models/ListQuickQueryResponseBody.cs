// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListQuickQueryResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQuickQueryResponseBodyData Data { get; set; }
        public class ListQuickQueryResponseBodyData : TeaModel {
            /// <summary>
            /// The number of saved searches per page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The saved search.
            /// </summary>
            [NameInMap("QuickQueryList")]
            [Validation(Required=false)]
            public List<ListQuickQueryResponseBodyDataQuickQueryList> QuickQueryList { get; set; }
            public class ListQuickQueryResponseBodyDataQuickQueryList : TeaModel {
                /// <summary>
                /// The alias of the saved search.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The query statement corresponding to the saved search.
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// The name of the saved search.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// The total number of saved searches that meet the query conditions.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
