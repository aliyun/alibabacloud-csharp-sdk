// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateDeliverableRequest : TeaModel {
        [NameInMap("foundation")]
        [Validation(Required=false)]
        public CreateDeliverableRequestFoundation Foundation { get; set; }
        public class CreateDeliverableRequestFoundation : TeaModel {
            [NameInMap("clusterConfig")]
            [Validation(Required=false)]
            public string ClusterConfig { get; set; }

            [NameInMap("foundationReferenceUID")]
            [Validation(Required=false)]
            public string FoundationReferenceUID { get; set; }

            [NameInMap("foundationVersion")]
            [Validation(Required=false)]
            public string FoundationVersion { get; set; }

            [NameInMap("foundationVersionUID")]
            [Validation(Required=false)]
            public string FoundationVersionUID { get; set; }

            [NameInMap("reusable")]
            [Validation(Required=false)]
            public bool? Reusable { get; set; }

        }

        [NameInMap("products")]
        [Validation(Required=false)]
        public List<CreateDeliverableRequestProducts> Products { get; set; }
        public class CreateDeliverableRequestProducts : TeaModel {
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("productUID")]
            [Validation(Required=false)]
            public string ProductUID { get; set; }

            [NameInMap("productVersion")]
            [Validation(Required=false)]
            public string ProductVersion { get; set; }

            [NameInMap("productVersionSpecName")]
            [Validation(Required=false)]
            public string ProductVersionSpecName { get; set; }

            [NameInMap("productVersionSpecUID")]
            [Validation(Required=false)]
            public string ProductVersionSpecUID { get; set; }

            [NameInMap("productVersionUID")]
            [Validation(Required=false)]
            public string ProductVersionUID { get; set; }

        }

    }

}
