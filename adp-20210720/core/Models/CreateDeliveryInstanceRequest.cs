// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class CreateDeliveryInstanceRequest : TeaModel {
        [NameInMap("clusterUID")]
        [Validation(Required=false)]
        public string ClusterUID { get; set; }

        [NameInMap("deliverableConfigUID")]
        [Validation(Required=false)]
        public string DeliverableConfigUID { get; set; }

        [NameInMap("deliverableUID")]
        [Validation(Required=false)]
        public string DeliverableUID { get; set; }

        [NameInMap("envUID")]
        [Validation(Required=false)]
        public string EnvUID { get; set; }

        [NameInMap("foundation")]
        [Validation(Required=false)]
        public CreateDeliveryInstanceRequestFoundation Foundation { get; set; }
        public class CreateDeliveryInstanceRequestFoundation : TeaModel {
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
            public string Reusable { get; set; }

        }

        [NameInMap("products")]
        [Validation(Required=false)]
        public List<CreateDeliveryInstanceRequestProducts> Products { get; set; }
        public class CreateDeliveryInstanceRequestProducts : TeaModel {
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

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

        [NameInMap("templateUID")]
        [Validation(Required=false)]
        public string TemplateUID { get; set; }

    }

}
