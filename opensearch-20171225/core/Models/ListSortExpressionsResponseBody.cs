// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListSortExpressionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the rough sort or fine sort expressions that were returned.
        /// 
        /// For more information, see [FirstRank](~~170007~~) and [SecondRank](~~170008~~).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSortExpressionsResponseBodyResult> Result { get; set; }
        public class ListSortExpressionsResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the expression is the default one.
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The time when the expression was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The description of the expression.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the expression.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The time when the expression was last updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
