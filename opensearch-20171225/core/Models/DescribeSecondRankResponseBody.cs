// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeSecondRankResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the fine sort expression.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeSecondRankResponseBodyResult Result { get; set; }
        public class DescribeSecondRankResponseBodyResult : TeaModel {
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
            /// The ID of the expression. This parameter appears only in the response.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// Indicates whether the expression is the default one. This parameter appears only in the response. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// Indicates whether the expression is a system expression. This parameter appears only in the response. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("isSys")]
            [Validation(Required=false)]
            public string IsSys { get; set; }

            /// <summary>
            /// The content of the fine sort expression.
            /// 
            /// You can define an expression that consists of fields, feature functions, and mathematical functions to implement complex sort logic.
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

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
