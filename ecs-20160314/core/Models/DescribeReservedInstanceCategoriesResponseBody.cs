// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeReservedInstanceCategoriesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReservedInstanceCategories")]
        [Validation(Required=false)]
        public DescribeReservedInstanceCategoriesResponseBodyReservedInstanceCategories ReservedInstanceCategories { get; set; }
        public class DescribeReservedInstanceCategoriesResponseBodyReservedInstanceCategories : TeaModel {
            [NameInMap("ReservedInstanceCategory")]
            [Validation(Required=false)]
            public List<DescribeReservedInstanceCategoriesResponseBodyReservedInstanceCategoriesReservedInstanceCategory> ReservedInstanceCategory { get; set; }
            public class DescribeReservedInstanceCategoriesResponseBodyReservedInstanceCategoriesReservedInstanceCategory : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("InstanceAmount")]
                [Validation(Required=false)]
                public int? InstanceAmount { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
