// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveImageBaselineStrategyRequest : TeaModel {
        /// <summary>
        /// The baseline check items.
        /// 
        /// > You can call the [DescribeImageBaselineStrategy](~~DescribeImageBaselineStrategy~~) operation to query baseline check items.
        /// </summary>
        [NameInMap("BaselineItemList")]
        [Validation(Required=false)]
        public string BaselineItemList { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the baseline check policy.
        /// 
        /// > You can call the [DescribeImageBaselineStrategy](~~DescribeImageBaselineStrategy~~) operation to query the IDs of baseline check policies.
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

    }

}
