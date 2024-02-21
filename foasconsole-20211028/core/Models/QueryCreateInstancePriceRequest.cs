// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class QueryCreateInstancePriceRequest : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public QueryCreateInstancePriceRequestResourceSpec ResourceSpec { get; set; }
        public class QueryCreateInstancePriceRequestResourceSpec : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("MemoryGB")]
            [Validation(Required=false)]
            public int? MemoryGB { get; set; }

        }

        [NameInMap("Storage")]
        [Validation(Required=false)]
        public QueryCreateInstancePriceRequestStorage Storage { get; set; }
        public class QueryCreateInstancePriceRequestStorage : TeaModel {
            [NameInMap("Oss")]
            [Validation(Required=false)]
            public QueryCreateInstancePriceRequestStorageOss Oss { get; set; }
            public class QueryCreateInstancePriceRequestStorageOss : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }

        }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
