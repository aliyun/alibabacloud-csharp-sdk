// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQueryProcessorsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the query analysis rule.
        /// 
        /// For more information, see [QueryProcessor](https://help.aliyun.com/document_detail/170014.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListQueryProcessorsResponseBodyResult> Result { get; set; }
        public class ListQueryProcessorsResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the query analysis rule is a default rule.
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The time when the query analysis rule was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The type of the industry to which the query analysis rule is applied. Valid values:
            /// 
            /// *   GENERAL
            /// *   ECOMMERCE
            /// *   IT_CONTENT
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The indexes to which the query analysis rule is applied.
            /// </summary>
            [NameInMap("indexes")]
            [Validation(Required=false)]
            public List<string> Indexes { get; set; }

            /// <summary>
            /// The name of the query analysis rule.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The features that are used in the query analysis rule.
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Processors { get; set; }

            /// <summary>
            /// The time when the query analysis rule was last modified.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
