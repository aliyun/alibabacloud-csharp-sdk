// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineStrategyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public DescribeImageBaselineStrategyResponseBodyStrategy Strategy { get; set; }
        public class DescribeImageBaselineStrategyResponseBodyStrategy : TeaModel {
            [NameInMap("BaselineItemList")]
            [Validation(Required=false)]
            public List<DescribeImageBaselineStrategyResponseBodyStrategyBaselineItemList> BaselineItemList { get; set; }
            public class DescribeImageBaselineStrategyResponseBodyStrategyBaselineItemList : TeaModel {
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                [NameInMap("ItemKey")]
                [Validation(Required=false)]
                public string ItemKey { get; set; }

                [NameInMap("NameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

            }

            [NameInMap("SelectedItemCount")]
            [Validation(Required=false)]
            public int? SelectedItemCount { get; set; }

            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            [NameInMap("TotalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
