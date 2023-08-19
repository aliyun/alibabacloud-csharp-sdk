// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineStrategyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about the baseline check policy.
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public DescribeImageBaselineStrategyResponseBodyStrategy Strategy { get; set; }
        public class DescribeImageBaselineStrategyResponseBodyStrategy : TeaModel {
            [NameInMap("BaselineItem")]
            [Validation(Required=false)]
            public string BaselineItem { get; set; }

            /// <summary>
            /// An array that contains the baselines.
            /// </summary>
            [NameInMap("BaselineItemList")]
            [Validation(Required=false)]
            public List<DescribeImageBaselineStrategyResponseBodyStrategyBaselineItemList> BaselineItemList { get; set; }
            public class DescribeImageBaselineStrategyResponseBodyStrategyBaselineItemList : TeaModel {
                /// <summary>
                /// The key of the baseline type.
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                /// <summary>
                /// The key of the baseline check item.
                /// </summary>
                [NameInMap("ItemKey")]
                [Validation(Required=false)]
                public string ItemKey { get; set; }

                /// <summary>
                /// The key of the name for the baseline.
                /// </summary>
                [NameInMap("NameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

            }

            /// <summary>
            /// The number of selected baseline check items.
            /// </summary>
            [NameInMap("SelectedItemCount")]
            [Validation(Required=false)]
            public int? SelectedItemCount { get; set; }

            /// <summary>
            /// The ID of the baseline check policy.
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// The name of the baseline check policy.
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// The total number of baseline check items.
            /// </summary>
            [NameInMap("TotalItemCount")]
            [Validation(Required=false)]
            public int? TotalItemCount { get; set; }

            /// <summary>
            /// The type of the baseline check policy. Valid values:
            /// 
            /// *   **default**: the default policy
            /// *   **full**: a policy that uses all baselines
            /// *   **normal**: a policy that uses general baselines
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
