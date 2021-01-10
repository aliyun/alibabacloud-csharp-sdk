// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCContainerServiceServiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListLDCContainerServiceServiceResponseBodyServices> Services { get; set; }
        public class ListLDCContainerServiceServiceResponseBodyServices : TeaModel {
            [NameInMap("LoadBalancerAddressType")]
            [Validation(Required=false)]
            public string LoadBalancerAddressType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Meta")]
            [Validation(Required=false)]
            public ListLDCContainerServiceServiceResponseBodyServicesMeta Meta { get; set; }
            public class ListLDCContainerServiceServiceResponseBodyServicesMeta : TeaModel {
                [NameInMap("CellDisplayName")]
                [Validation(Required=false)]
                public string CellDisplayName { get; set; }
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }
            };

            [NameInMap("Status")]
            [Validation(Required=false)]
            public ListLDCContainerServiceServiceResponseBodyServicesStatus Status { get; set; }
            public class ListLDCContainerServiceServiceResponseBodyServicesStatus : TeaModel {
                [NameInMap("LoadBalancerIp")]
                [Validation(Required=false)]
                public string LoadBalancerIp { get; set; }
            };

        }

    }

}
