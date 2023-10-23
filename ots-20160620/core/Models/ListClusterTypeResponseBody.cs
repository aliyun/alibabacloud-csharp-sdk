// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ots20160620.Models
{
    public class ListClusterTypeResponseBody : TeaModel {
        [NameInMap("ClusterTypeDetailList")]
        [Validation(Required=false)]
        public ListClusterTypeResponseBodyClusterTypeDetailList ClusterTypeDetailList { get; set; }
        public class ListClusterTypeResponseBodyClusterTypeDetailList : TeaModel {
            [NameInMap("ClusterTypeDetail")]
            [Validation(Required=false)]
            public List<ListClusterTypeResponseBodyClusterTypeDetailListClusterTypeDetail> ClusterTypeDetail { get; set; }
            public class ListClusterTypeResponseBodyClusterTypeDetailListClusterTypeDetail : TeaModel {
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("IsMultiAZ")]
                [Validation(Required=false)]
                public bool? IsMultiAZ { get; set; }

            }

        }

        [NameInMap("ClusterTypeInfos")]
        [Validation(Required=false)]
        public ListClusterTypeResponseBodyClusterTypeInfos ClusterTypeInfos { get; set; }
        public class ListClusterTypeResponseBodyClusterTypeInfos : TeaModel {
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public List<string> ClusterType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
