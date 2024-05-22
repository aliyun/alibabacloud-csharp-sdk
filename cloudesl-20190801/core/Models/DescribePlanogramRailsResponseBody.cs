// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribePlanogramRailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PlanogramRailInfos")]
        [Validation(Required=false)]
        public List<DescribePlanogramRailsResponseBodyPlanogramRailInfos> PlanogramRailInfos { get; set; }
        public class DescribePlanogramRailsResponseBodyPlanogramRailInfos : TeaModel {
            [NameInMap("GapUnit")]
            [Validation(Required=false)]
            public int? GapUnit { get; set; }

            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }

            [NameInMap("RailCode")]
            [Validation(Required=false)]
            public string RailCode { get; set; }

            [NameInMap("Shelf")]
            [Validation(Required=false)]
            public string Shelf { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
