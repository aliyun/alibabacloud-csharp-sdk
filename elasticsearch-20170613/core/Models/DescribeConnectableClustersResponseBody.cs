// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeConnectableClustersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeConnectableClustersResponseBodyResult> Result { get; set; }
        public class DescribeConnectableClustersResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the instance that can communicate with each other.
            /// </summary>
            [NameInMap("instances")]
            [Validation(Required=false)]
            public string Instances { get; set; }

            /// <summary>
            /// The network type of the instance.
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

        }

    }

}
