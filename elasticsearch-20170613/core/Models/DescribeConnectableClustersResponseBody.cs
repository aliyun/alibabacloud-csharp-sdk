// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeConnectableClustersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeConnectableClustersResponseBodyResult> Result { get; set; }
        public class DescribeConnectableClustersResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-xxx</para>
            /// </summary>
            [NameInMap("instances")]
            [Validation(Required=false)]
            public string Instances { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

        }

    }

}
