// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("DeployMetadata")]
        [Validation(Required=false)]
        public string DeployMetadata { get; set; }

        [NameInMap("PublishTime")]
        [Validation(Required=false)]
        public string PublishTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("SupplierUrl")]
        [Validation(Required=false)]
        public string SupplierUrl { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        [NameInMap("ServiceInfos")]
        [Validation(Required=false)]
        public List<GetServiceResponseBodyServiceInfos> ServiceInfos { get; set; }
        public class GetServiceResponseBodyServiceInfos : TeaModel {
            [NameInMap("Locale")]
            [Validation(Required=false)]
            public string Locale { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ShortDescription")]
            [Validation(Required=false)]
            public string ShortDescription { get; set; }

        }

        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

    }

}
