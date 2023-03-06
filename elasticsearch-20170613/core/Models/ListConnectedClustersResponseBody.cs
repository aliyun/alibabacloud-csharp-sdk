// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListConnectedClustersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListConnectedClustersResponseBodyResult Result { get; set; }
        public class ListConnectedClustersResponseBodyResult : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListConnectedClustersResponseBodyResultResult> Result { get; set; }
            public class ListConnectedClustersResponseBodyResultResult : TeaModel {
                /// <summary>
                /// The ID of the remote instance that is connected to the network of the current instance.
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

}
