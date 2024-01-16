// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeNodeParamTagsResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the recommended path.
        /// </summary>
        [NameInMap("ParamReferredPaths")]
        [Validation(Required=false)]
        public List<DescribeNodeParamTagsResponseBodyParamReferredPaths> ParamReferredPaths { get; set; }
        public class DescribeNodeParamTagsResponseBodyParamReferredPaths : TeaModel {
            /// <summary>
            /// The name of the upstream node.
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

            /// <summary>
            /// The paths.
            /// </summary>
            [NameInMap("ReferredPath")]
            [Validation(Required=false)]
            public List<string> ReferredPath { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
