// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FindContainerNetworkConnectResponseBody : TeaModel {
        [NameInMap("Connects")]
        [Validation(Required=false)]
        public List<FindContainerNetworkConnectResponseBodyConnects> Connects { get; set; }
        public class FindContainerNetworkConnectResponseBodyConnects : TeaModel {
            [NameInMap("DstContainer")]
            [Validation(Required=false)]
            public FindContainerNetworkConnectResponseBodyConnectsDstContainer DstContainer { get; set; }
            public class FindContainerNetworkConnectResponseBodyConnectsDstContainer : TeaModel {
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

            }

            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("SrcContainer")]
            [Validation(Required=false)]
            public FindContainerNetworkConnectResponseBodyConnectsSrcContainer SrcContainer { get; set; }
            public class FindContainerNetworkConnectResponseBodyConnectsSrcContainer : TeaModel {
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

            }

            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public string SrcPort { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public FindContainerNetworkConnectResponseBodyPageInfo PageInfo { get; set; }
        public class FindContainerNetworkConnectResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
