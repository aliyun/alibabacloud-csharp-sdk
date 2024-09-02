// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GenerateMergedTableResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GenerateMergedTableResponseBodyResult Result { get; set; }
        public class GenerateMergedTableResponseBodyResult : TeaModel {
            /// <summary>
            /// The tables on which the JOIN operation is performed.
            /// </summary>
            [NameInMap("fromTable")]
            [Validation(Required=false)]
            public Dictionary<string, object> FromTable { get; set; }

            /// <summary>
            /// The wide table that is generated after the JOIN operation is performed on multiple tables.
            /// </summary>
            [NameInMap("mergeTable")]
            [Validation(Required=false)]
            public Dictionary<string, object> MergeTable { get; set; }

            /// <summary>
            /// The primary key.
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

        }

    }

}
