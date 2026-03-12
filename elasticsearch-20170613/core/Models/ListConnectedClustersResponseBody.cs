// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListConnectedClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListConnectedClustersResponseBodyResult Result { get; set; }
        public class ListConnectedClustersResponseBodyResult : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListConnectedClustersResponseBodyResultResult> Result { get; set; }
            public class ListConnectedClustersResponseBodyResultResult : TeaModel {
                [NameInMap("instances")]
                [Validation(Required=false)]
                public string Instances { get; set; }

                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

            }

        }

    }

}
