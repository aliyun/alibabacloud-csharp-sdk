// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class QueryConvertInstancePriceRequest : TeaModel {
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsAutoRenew")]
        [Validation(Required=false)]
        public bool? IsAutoRenew { get; set; }

        [NameInMap("NamespaceResourceSpecs")]
        [Validation(Required=false)]
        public List<QueryConvertInstancePriceRequestNamespaceResourceSpecs> NamespaceResourceSpecs { get; set; }
        public class QueryConvertInstancePriceRequestNamespaceResourceSpecs : TeaModel {
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public QueryConvertInstancePriceRequestNamespaceResourceSpecsResourceSpec ResourceSpec { get; set; }
            public class QueryConvertInstancePriceRequestNamespaceResourceSpecsResourceSpec : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

        }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
