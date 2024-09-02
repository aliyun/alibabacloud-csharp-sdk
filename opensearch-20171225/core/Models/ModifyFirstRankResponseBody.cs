// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyFirstRankResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the rough sort expression.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ModifyFirstRankResponseBodyResult Result { get; set; }
        public class ModifyFirstRankResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the expression is the default one.
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The description of the rough sort expression.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The information about the expression.
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<ModifyFirstRankResponseBodyResultMeta> Meta { get; set; }
            public class ModifyFirstRankResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// The parameters that are used by a function in the expression.
                /// </summary>
                [NameInMap("arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                /// <summary>
                /// The attribute, feature function, or field to be searched for.
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// The weight. Valid values: -100000 to 100000. The value cannot be 0.
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            /// <summary>
            /// The name of the expression.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
