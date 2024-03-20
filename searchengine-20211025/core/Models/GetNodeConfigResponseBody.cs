// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetNodeConfigResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result set.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetNodeConfigResponseBodyResult Result { get; set; }
        public class GetNodeConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the expression is the default one.
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The number of data replicas.
            /// </summary>
            [NameInMap("dataDuplicateNumber")]
            [Validation(Required=false)]
            public int? DataDuplicateNumber { get; set; }

            /// <summary>
            /// The number of data shards.
            /// </summary>
            [NameInMap("dataFragmentNumber")]
            [Validation(Required=false)]
            public int? DataFragmentNumber { get; set; }

            [NameInMap("flowRatio")]
            [Validation(Required=false)]
            public int? FlowRatio { get; set; }

            /// <summary>
            /// The minimum service ratio.
            /// </summary>
            [NameInMap("minServicePercent")]
            [Validation(Required=false)]
            public int? MinServicePercent { get; set; }

            /// <summary>
            /// Indicates whether the node is associated with the cluster.
            /// </summary>
            [NameInMap("published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

        }

    }

}
