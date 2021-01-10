// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCFederationSpannerClusterResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListLDCFederationSpannerClusterResponseBodyData> Data { get; set; }
        public class ListLDCFederationSpannerClusterResponseBodyData : TeaModel {
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public string CreateTimestamp { get; set; }

            [NameInMap("Disk")]
            [Validation(Required=false)]
            public long? Disk { get; set; }

            [NameInMap("ExpectClusterState")]
            [Validation(Required=false)]
            public string ExpectClusterState { get; set; }

            [NameInMap("Flavor")]
            [Validation(Required=false)]
            public string Flavor { get; set; }

            [NameInMap("HostNetwork")]
            [Validation(Required=false)]
            public bool? HostNetwork { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public long? Instances { get; set; }

            [NameInMap("Mem")]
            [Validation(Required=false)]
            public long? Mem { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }

            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public string UpdateTimestamp { get; set; }

            [NameInMap("WorkspaceGroup")]
            [Validation(Required=false)]
            public string WorkspaceGroup { get; set; }

        }

    }

}
