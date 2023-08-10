// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFirstRanksResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about each rough sort expression.
        /// 
        /// For more information, see [FirstRank](~~170007~~).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListFirstRanksResponseBodyResult> Result { get; set; }
        public class ListFirstRanksResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the expression is the default one.
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

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
            /// The content of the expression.
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<ListFirstRanksResponseBodyResultMeta> Meta { get; set; }
            public class ListFirstRanksResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// The parameters that are used by a function in the expression.
                /// 
                /// For more information, see [Rough sort functions](~~180765~~).
                /// </summary>
                [NameInMap("arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                /// <summary>
                /// The attribute, feature function, or field to be searched for.
                /// 
                /// For more information about supported feature functions, see [Rough sort functions](~~180765~~).
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// The weight.
                /// 
                /// Valid values: \[-100000,100000] (excluding 0).
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// The name of the expression.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
