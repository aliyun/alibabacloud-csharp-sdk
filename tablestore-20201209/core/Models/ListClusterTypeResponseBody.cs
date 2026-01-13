// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class ListClusterTypeResponseBody : TeaModel {
        [NameInMap("ClusterTypeDetailList")]
        [Validation(Required=false)]
        public List<ListClusterTypeResponseBodyClusterTypeDetailList> ClusterTypeDetailList { get; set; }
        public class ListClusterTypeResponseBodyClusterTypeDetailList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>SSD</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsMultiAZ")]
            [Validation(Required=false)]
            public bool? IsMultiAZ { get; set; }

        }

        [NameInMap("ClusterTypeList")]
        [Validation(Required=false)]
        public List<string> ClusterTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>88BA193C-4918-08C4-9870-E1FE6BBECF34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
