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

        /// <summary>
        /// <para>The return results.</para>
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
                /// <para>The ID of the remote instance that is connected to the network of the current instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>es-cn-09k1rocex0006****</para>
                /// </summary>
                [NameInMap("instances")]
                [Validation(Required=false)]
                public string Instances { get; set; }

                /// <summary>
                /// <para>The network type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

            }

        }

    }

}
