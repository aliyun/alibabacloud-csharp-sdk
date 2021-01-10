// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCContainerServiceIngressResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Ingresses")]
        [Validation(Required=false)]
        public List<ListLDCContainerServiceIngressResponseBodyIngresses> Ingresses { get; set; }
        public class ListLDCContainerServiceIngressResponseBodyIngresses : TeaModel {
            [NameInMap("UnifiedAccessInstanceName")]
            [Validation(Required=false)]
            public string UnifiedAccessInstanceName { get; set; }

            [NameInMap("Meta")]
            [Validation(Required=false)]
            public ListLDCContainerServiceIngressResponseBodyIngressesMeta Meta { get; set; }
            public class ListLDCContainerServiceIngressResponseBodyIngressesMeta : TeaModel {
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

        }

    }

}
