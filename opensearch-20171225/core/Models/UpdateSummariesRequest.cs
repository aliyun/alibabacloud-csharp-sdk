// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateSummariesRequest : TeaModel {
        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateSummariesRequestBody> Body { get; set; }
        public class UpdateSummariesRequestBody : TeaModel {
            /// <summary>
            /// The HTML tag that is used to highlight terms in red.
            /// </summary>
            [NameInMap("element")]
            [Validation(Required=false)]
            public string Element { get; set; }

            /// <summary>
            /// The connector that is used to connect segments.
            /// </summary>
            [NameInMap("ellipsis")]
            [Validation(Required=false)]
            public string Ellipsis { get; set; }

            /// <summary>
            /// The field.
            /// </summary>
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// The length of a segment.
            /// </summary>
            [NameInMap("len")]
            [Validation(Required=false)]
            public int? Len { get; set; }

            /// <summary>
            /// The number of segments.
            /// </summary>
            [NameInMap("snippet")]
            [Validation(Required=false)]
            public int? Snippet { get; set; }

        }

        /// <summary>
        /// Specifies whether the request is a dry run.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
