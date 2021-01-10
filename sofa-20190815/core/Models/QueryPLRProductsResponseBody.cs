// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryPLRProductsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<QueryPLRProductsResponseBodyProducts> Products { get; set; }
        public class QueryPLRProductsResponseBodyProducts : TeaModel {
            [NameInMap("CapabilityInfo")]
            [Validation(Required=false)]
            public string CapabilityInfo { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DocLink")]
            [Validation(Required=false)]
            public string DocLink { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("IsHot")]
            [Validation(Required=false)]
            public bool? IsHot { get; set; }

            [NameInMap("MeritInfo")]
            [Validation(Required=false)]
            public string MeritInfo { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Payment")]
            [Validation(Required=false)]
            public string Payment { get; set; }

            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("Dependents")]
            [Validation(Required=false)]
            public List<string> Dependents { get; set; }

        }

        [NameInMap("Productsets")]
        [Validation(Required=false)]
        public List<QueryPLRProductsResponseBodyProductsets> Productsets { get; set; }
        public class QueryPLRProductsResponseBodyProductsets : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HasDiscount")]
            [Validation(Required=false)]
            public bool? HasDiscount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Payment")]
            [Validation(Required=false)]
            public string Payment { get; set; }

            [NameInMap("PlanCode")]
            [Validation(Required=false)]
            public string PlanCode { get; set; }

            [NameInMap("ContainingProducts")]
            [Validation(Required=false)]
            public List<string> ContainingProducts { get; set; }

        }

    }

}
