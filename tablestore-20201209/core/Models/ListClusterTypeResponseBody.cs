// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListClusterTypeResponseBody : TeaModel {
        [NameInMap("ClusterTypeInfos")]
        [Validation(Required=false)]
        public List<ListClusterTypeResponseBodyClusterTypeInfos> ClusterTypeInfos { get; set; }
        public class ListClusterTypeResponseBodyClusterTypeInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SSD</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("IsMultiAZ")]
            [Validation(Required=false)]
            public bool? IsMultiAZ { get; set; }

        }

        [NameInMap("ClusterTypes")]
        [Validation(Required=false)]
        public List<string> ClusterTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>88BA193C-4918-08C4-9870-E1FE6BBECF34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
